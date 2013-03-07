using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using HelloData.FWCommon.Utils;
using ReadSpider.Common;
using ReadSpider.Common.Logic;
using ReadSpider.Common.Model;

namespace ReadSpider
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //http://www.booksky.org/  http://www.sodu.org
        private void button1_Click(object sender, EventArgs e)
        {
            AddUrl add = new AddUrl();
            if (add.ShowDialog() == DialogResult.OK)
            {
                Read_SiteManager.Instance.Save(add.site);
                updateView();
            }
        }
        // http://www.wanshuba.com/
        private Dictionary<int, Read_Book> books = new Dictionary<int, Read_Book>();
        private Dictionary<string, string> urls = new Dictionary<string, string>();
        public void DoSpilderSite(string url)
        {
            List<string> currentUrls = new List<string>();
            HttpHelper1 http = new HttpHelper1();
            string html = http.GetHtml(new HttpItem() { URL = url });
            string reg = "<a.*?href=[\"'](.*?)[\"' ]>(.*?)</a>";
            Regex reg_ag = new Regex(reg, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            MatchCollection match = reg_ag.Matches(html);
            if (match.Count > 0)
            {
                foreach (Match item in match)
                {
                    reg = "Book/(.*?)/Index.shtml";
                    Regex bookreg = new Regex(reg, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    string itemurl = item.Groups[1].Value.ToLower();

                    MatchCollection match1 = bookreg.Matches(itemurl);

                    if ((match1.Count > 0) && !books.ContainsKey(int.Parse(match1[0].Groups[1].Value)))
                    {
                        Read_Book book = new Read_Book();
                        book.BookID = int.Parse(match1[0].Groups[1].Value);
                        book.BookName = item.Groups[2].Value.ToLower();
                        books.Add(int.Parse(match1[0].Groups[1].Value), book);
                        continue;
                    }
                    if (!urls.ContainsKey(itemurl))
                    {
                        showlog(itemurl);
                        if (itemurl.Contains("http:") && !itemurl.Contains("wanshuba.com"))
                            continue;
                        urls.Add(item.Groups[1].Value.ToLower(), item.Groups[2].Value.ToLower());
                        currentUrls.Add(item.Groups[1].Value.ToLower());
                    }
                }
            }
            foreach (var itemurl in currentUrls)
            {
                DoSpilderSite(itemurl);
            }
        }
        private void showlog(string p)
        {
            try
            {
                richTextBox1.Invoke(new MethodInvoker(delegate
                {
                    richTextBox1.AppendText(p + "\r\n");
                }));
            }
            catch { }
        }
        /// <summary>
        /// 主程序的多任务操作类
        /// </summary>
        public ThreadActions ThreadAction;
        /// <summary>
        /// 队列的顺序，主要用来停止启用，删除任务
        /// </summary>
        public int index
        {
            get
            {
                int innerindex = _index;
                _index++;
                return innerindex;
            }
            set
            {
                _index = 0;
            }
        }
        int _index = 0;
        /// <summary>
        /// 添加任务队列
        /// </summary>
        /// <param name="taskmodel"></param>
        void AddTask(TaskModel taskmodel)
        {
            if (!taskmodel.IsOutOrder)
                taskmodel.taskState = TaskState.Parper;
            else
                taskmodel.taskState = TaskState.Wait;
            taskmodel.CreateTime = DateTime.Now;
            ThreadAction.Tasks.Add(taskmodel);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "启动")
            {
                AddTask(new TaskModel
                {
                    IsOutOrder = true,
                    Index = index,
                    DoAction = Actions.SpilderChapter
                });
                AddTask(new TaskModel
                {
                    IsOutOrder = true,
                    Index = index,
                    DoAction = Actions.SpilderBook
                });
                AddTask(new TaskModel
                {
                    IsOutOrder = true,
                    Index = index,
                    DoAction = Actions.SpilderSite
                });
                ThreadAction.Start();
                button3.Text = "停止";
            }
            else
            {
                button3.Text = "启动";
                ThreadAction.Abort();
                ThreadAction.Tasks.Clear();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateView();
            ThreadAction = new ThreadActions(this);
            IniHelper helper = new IniHelper(AppDomain.CurrentDomain.BaseDirectory.ToString() + "setting.ini");
            AppContent.Current.ReadSet();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            setting setting = new setting();
            setting.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                editurl add = new editurl();
                add.siteid = (int)listView2.SelectedItems[0].Tag;
                if (add.ShowDialog() == DialogResult.OK)
                {
                    Read_SiteManager.Instance.Update(add.rsite);
                    updateView();
                }
            }

        }

        public void updateView()
        {
            AppContent.AllSites = Read_SiteManager.Instance.GetList(0, -1);
            listView2.Items.Clear();
            foreach (Read_Site site in AppContent.AllSites)
            {
                ListViewItem item = new ListViewItem(site.SiteName);
                item.Tag = site.ID;
                item.SubItems.Add(site.SiteUrl);
                listView2.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateView();
        }
    }
}
