#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/1/31 14:29:50
* 文件名：ThreadActions
* 版本：V1.0.1
* 联系方式：511522329  
*
* 修改者： 时间： 
* 修改说明：
* ========================================================================
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using HelloData.FWCommon.Utils;
using ReadSpider.Common;
using ReadSpider.Common.Logic;

namespace ReadSpider
{
    public class ThreadActions
    {
        /// <summary>
        /// 启动操作
        /// </summary>
        public void Start()
        {
            foreach (var task in Tasks)
            {
                task.taskState = TaskState.Parper;

            }
            DoAction();
        }
        /// <summary>
        /// 停止操作
        /// </summary>
        public void Abort()
        {
            foreach (var task in Tasks)
            {
                task.taskState = TaskState.Pause;
                task.CurrentThread.Abort();
            }
        }

        /// <summary>
        /// 操作的任务队列
        /// </summary>
        public List<TaskModel> Tasks { get; set; }
        /// <summary>
        /// 更新队列
        /// </summary>
        public event EventHandler UpdateTask;
        /// <summary>
        /// 更新统计
        /// </summary>
        public event EventHandler UpdateSummar;
        /// <summary>
        /// 是否自动跳码
        /// </summary>
        public bool IsAutoJumpCheck = false;


        public static object lockObj = new object();

        public int ActionIndex = 0;




        /// <summary>
        /// 更新列表的状态值信息
        /// </summary>
        public event EventHandler UpdateView;
        public Form Owner;

        public ThreadActions(Form owner)
        {
            Tasks = new List<TaskModel>();
            Owner = owner;
        }

        /// <summary>
        /// 操作返回的结果
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        /// 各种操作
        /// </summary> 
        public void DoAction()
        {
            if (!IsRuning)
            {
                IsRuning = true;
                ThreadPool.QueueUserWorkItem(Working);
            }
        }
        /// <summary>
        /// 是否正在运行
        /// </summary>
        public bool IsRuning = false;
        private void Working(object sender)
        {

            {
                try
                {
                    foreach (TaskModel item in Tasks)
                    {

                        if (false == item.IsSupShutDown && item.RunTime > 0)
                        {
                            continue;
                        }
                        if (item.taskState == TaskState.Run)
                        {
                            foreach (TaskModel childitem in Tasks)
                            {
                                if (childitem.ParentAction == item.DoAction)
                                {
                                    childitem.taskState = TaskState.Complete;
                                    if (childitem.CurrentThread != null)
                                        childitem.CurrentThread.Abort();
                                }
                            }
                        }

                        //只处理Parper状态的 
                        if (item.taskState == TaskState.Parper)
                        {
                            //如果不是乱序执行，就必须先执行完所有的这些才行。
                            if (!item.IsOutOrder)
                            {
                                foreach (TaskModel childitem in Tasks)
                                {
                                    if (childitem.ParentAction == item.DoAction)
                                    {
                                        childitem.taskState = TaskState.Wait;
                                    }
                                }
                                //开始执行
                                item.taskState = TaskState.Run;
                                ThreadPool.QueueUserWorkItem(DoPerAction, item);
                            }
                            else
                            {
                                //开始执行
                                item.taskState = TaskState.Run;
                                // DoPerAction(item); 
                                Thread t = new Thread(DoPerAction);
                                t.Start(item);
                                item.CurrentThread = t;
                            }
                        }
                        else if (item.taskState == TaskState.Wait)
                        {
                            foreach (TaskModel paritem in Tasks)
                            {
                                if (paritem.DoAction == item.ParentAction && paritem.taskState == TaskState.Complete)
                                {
                                    item.taskState = TaskState.Parper;
                                }
                            }
                        }
                        else if (item.taskState == TaskState.Stop || item.taskState == TaskState.Pause || item.taskState == TaskState.Complete)
                        {
                            //整理还在处理中的任务

                        }
                    }
                    UpdateTaskView();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    Showlog(ex.Message);
                }
            }
        }
        /// <summary>
        /// 更新任务队列
        /// </summary>
        public void UpdateTaskView()
        {
            try
            {
                Owner.Invoke(new MethodInvoker(delegate
                {
                    //UpdateTask(this, new EventArgs());
                    //UpdateView(this, new EventArgs());
                    //UpdateSummar(this, new EventArgs());
                }));
            }
            catch
            {

            }
        }
        /// <summary>
        /// 多久更新任务队列
        /// </summary>
        public int Timer { get; set; }

        /// <summary>
        /// 执行具体的操作
        /// </summary>
        /// <param name="item"></param>
        public void DoPerAction(object sender)
        {
            TaskModel item = sender as TaskModel;
            try
            {

                Thread.CurrentThread.IsBackground = true;

                item.RunTime++;
                switch (item.DoAction)
                {
                    case Actions.SpilderBook:
                        DoSpilderBook(item);
                        break;
                    case Actions.SpilderSite:
                        DoSpilderSite(item);
                        break;
                    case Actions.SpilderChapter:
                        DoSpilderChatper(item);
                        break;
                }
                foreach (var taskmodel in Tasks)
                {
                    if (taskmodel.Index == item.Index)
                    {
                        taskmodel.taskState = TaskState.Complete;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Showlog(ex.Message);
                foreach (var taskmodel in Tasks)
                {
                    if (taskmodel.Index == item.Index)
                    {
                        taskmodel.taskState = TaskState.Stop;
                        break;
                    }
                }
            }
        }
        private void Showlog(string p)
        {
            try
            {
                ((MainForm)this.Owner).richTextBox1.Invoke(new MethodInvoker(
                                      () =>
                                      ((MainForm)this.Owner).richTextBox1.AppendText(
                                          DateTime.Now.ToString("HH:mm:ss  ") + p + "\r\n")));
            }
            catch { }
        }

        /// <summary>
        /// 全网扫描
        /// </summary>
        /// <param name="model"></param>
        public void DoSpilderSite(object model)
        {
            while (true)
            {
                Read_UpdateManager.Instance.UpdateDate();
                foreach (Read_Site readSite in AppContent.AllSites)
                {
                    if (readSite.IsActive == null || (readSite.IsActive.HasValue && readSite.IsActive.Value))
                    {
                        currentReadSite = readSite;
                        bookids = Read_BookManager.Instance.GetBookIds(readSite.ID);
                        DositeForeach(readSite);
                        Read_BookManager.Instance.InsertList(_books);
                        Showlog("采集到新书" + _books.Count + "本");
                        Read_SiteManager.Instance.UpdateSite(readSite);
                        _books = new Dictionary<int, Read_Book>();
                        _urls = new Dictionary<string, string>();
                    }
                }
                Thread.Sleep(60 * 1000 * AppContent.Current.currentSetting.SpiderOutTime);
            }
        }
        public Read_Site currentReadSite = new Read_Site();

        private Dictionary<int, Read_Book> _books = new Dictionary<int, Read_Book>();
        private List<int> bookids = new List<int>();
        private Dictionary<string, string> _urls = new Dictionary<string, string>();
        private void DositeForeach(Read_Site site)
        {
            try
            {
                string url = site.SiteUrl;

                List<string> currentUrls = new List<string>();
                HttpHelper1 http = new HttpHelper1();
                string html = http.GetHtml(new HttpItem() { URL = url });
                Dictionary<string, string> urls = HtmlHelper.GetAllLink(html, url, site.SpliderDeep.Value, site.IsNotSplideParms.Value);

                if (urls.Count > 0)
                {
                    foreach (var item in urls)
                    {
                        Regex bookreg = new Regex(site.BookReg, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                        string itemurl = item.Key;
                        if (string.IsNullOrEmpty(itemurl))
                            continue;
                        MatchCollection match1 = bookreg.Matches(itemurl);

                        if ((match1.Count > 0))
                        {
                            List<int> list = bookids.Where(id => id == int.Parse(match1[0].Groups[1].Value)).ToList();
                            if (!_books.ContainsKey(int.Parse(match1[0].Groups[1].Value))
                                && list.Count == 0)
                            {
                                Read_Book book = new Read_Book();
                                book.SiteID = site.ID;
                                book.BookID = int.Parse(match1[0].Groups[1].Value);
                                book.BookName = currentHtml(HtmlHelper.ParseTags(item.Value));
                                book.BookUrl = site.SiteUrl.TrimEnd('/') + site.BookReg.Replace("(.*?)", book.BookID.ToString());
                                book.ChapterUrl = GetRealUrl(site.ChapterUrl, book.BookID.Value, 0);
                                if (!string.IsNullOrEmpty(book.BookName))
                                    _books.Add(int.Parse(match1[0].Groups[1].Value), book);

                            }
                            continue;
                        }
                        if (!string.IsNullOrEmpty(itemurl) && !_urls.ContainsKey(itemurl))
                        {
                            if (itemurl.Split('/').Length - 3 <= site.SpliderDeep.Value)
                            {
                                Showlog(itemurl);
                                _urls.Add(itemurl, item.Value);
                                currentUrls.Add(itemurl);
                            }
                        }
                    }
                }
                foreach (var itemurl in currentUrls)
                {
                    Read_Site readsite = site;
                    readsite.SiteUrl = itemurl;
                    DositeForeach(readsite);
                }
            }
            catch (Exception ex)
            {
                Showlog(ex.Message);
            }
        }

        public string currentHtml(string html)
        {
            String[] strings = html.Split('>');
            if (strings.Length > 1)
                return strings[strings.Length - 1];
            return html;
        }

        public string CheckUrl(string url)
        {
            url = url.ToLower();
            if (url.Contains("javascript"))
                return string.Empty;
            string[] sts = url.Split('"');
            if (sts.Length > 1)
            {
                return sts[0].TrimEnd('"');
            }
            sts = url.Split('\'');
            if (sts.Length > 1)
            {
                return sts[0].TrimEnd('\'');
            }
            return url;
        }

        public string GetRealUrl(string orginurl, int bookid, int chapterid)
        {
            if (orginurl != null)
                return orginurl.ToLower().
                      Replace("$bookid$$r3$", bookid.ToString().Substring(0, bookid.ToString().Length > 3 ? bookid.ToString().Length - 3 : 0)).
                      Replace("$bookid$", bookid.ToString()).
                      Replace("$chapterid$", chapterid.ToString()).
                      Replace("$r3$", bookid.ToString().Substring(0, bookid.ToString().Length > 3 ? bookid.ToString().Length - 3 : 0));
            return string.Empty;
        }

        /// <summary>
        /// 根据章节找内容 
        /// </summary>
        /// <param name="model"></param>
        public void DoSpilderChatper(object model)
        {
            while (true)
            {
                Showlog("开始根据章节找内容");
                List<Read_Chapter> chapters = Read_ChapterManager.Instance.GetChapters(100);
                List<Read_Chapter> Upchapters = new List<Read_Chapter>();
                foreach (var readchapter in chapters)
                {
                    try
                    {
                        Read_Site currentSite = new Read_Site();
                        foreach (Read_Site sites in AppContent.AllSites)
                        {
                            if (sites.ID == readchapter.SiteID)
                            {
                                currentSite = sites;
                                break;
                            }
                        }
                        if (currentSite.ID == 0)
                            continue;

                        HttpHelper1 http = new HttpHelper1();
                        string html = http.GetHtml(new HttpItem() { URL = readchapter.ChapterContentUrl });
                        string reg = currentSite.ContentReg;
                        Regex reg_ag = new Regex(reg, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                        MatchCollection match = reg_ag.Matches(html);
                        if (match.Count > 0)
                        {
                            foreach (Match item in match)
                            {
                                Read_Chapter chapter = new Read_Chapter();
                                chapter.ID = readchapter.ID;
                                chapter.ChapterContent = HtmlHelper.ParseTags(item.Groups[currentSite.ContentRegIndex.Value].Value.ToLower());
                                Upchapters.Add(chapter);
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                Read_ChapterManager.Instance.UpdateList(Upchapters);
                if (chapters.Count > 0)
                    Read_UpdateManager.Instance.UpdateChapter(chapters[chapters.Count - 1].ID);
                Showlog("已经更新" + Upchapters.Count + "篇章节内容");
                Thread.Sleep(60 * 1000 * AppContent.Current.currentSetting.SpiderChapter);
            }
        }
        /// <summary>
        /// 根据书找章节
        /// </summary>
        /// <param name="model"></param>
        public void DoSpilderBook(object model)
        {
            while (true)
            {
                Showlog("开始根据书扫描章节");
                List<Read_Book> books = Read_BookManager.Instance.GetBooks(500);
                foreach (var book in books)
                {
                    Read_Site currentSite = new Read_Site();
                    foreach (Read_Site sites in AppContent.AllSites)
                    {
                        if (sites.ID == book.SiteID)
                        {
                            currentSite = sites;
                            book.ChapterReg = sites.ChapterReg;
                            book.ContentUrl = sites.ContentUrl;
                        }
                    }
                    if (currentSite.ID == 0)
                        continue;
                    try
                    {
                        List<Read_Chapter> chapters = new List<Read_Chapter>();
                        HttpHelper1 http = new HttpHelper1();
                        string html = http.GetHtml(new HttpItem() { URL = book.ChapterUrl });
                        Dictionary<string, string> urls = HtmlHelper.GetAllLink(html, book.ChapterUrl, currentSite.SpliderDeep.Value, currentSite.IsNotSplideParms.Value);
                        if (urls.Count > 0)
                        {
                            foreach (var item in urls)
                            {
                                try
                                {
                                    Regex bookreg = new Regex(book.ChapterReg, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                                    string itemurl = item.Key;
                                    MatchCollection match1 = bookreg.Matches(itemurl);
                                    if ((match1.Count > 0) && !_books.ContainsKey(int.Parse(match1[0].Groups[currentSite.ChapterRegIndex.Value].Value)))
                                    {
                                        Read_Chapter chapter = new Read_Chapter();
                                        chapter.BookID = book.BookID;
                                        int chapterid = 0;
                                        if (int.TryParse(match1[0].Groups[currentSite.ChapterRegIndex.Value].Value,
                                                         out chapterid))
                                        {
                                            chapter.ChapterID = chapterid;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        chapter.ChapterContentUrl = GetRealUrl(book.ContentUrl, book.BookID.Value,
                                                                               chapter.ChapterID.Value);
                                        chapter.SiteID = book.SiteID;
                                        chapter.ChapterName = item.Value;
                                        if (book.LastChapteID == null || chapter.ChapterID > book.LastChapteID)
                                            chapters.Add(chapter);
                                    }
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                        }
                        Read_ChapterManager.Instance.InsertList(chapters);
                        Showlog(string.Format("找到《{0}》书{1}个章节", book.BookName, chapters.Count));
                        if (chapters.Count > 0)
                        {
                            book.LastChapteID = chapters[chapters.Count - 1].ChapterID;
                            Read_BookManager.Instance.UpdateBook(book);
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
                if (books.Count > 0)
                    Read_UpdateManager.Instance.UpdateBook(books[books.Count - 1].ID);
                Thread.Sleep(60 * 1000 * AppContent.Current.currentSetting.SpiderBook);
            }
        }
    }
    public enum Actions
    {
        SpilderSite,
        SpilderBook,
        SpilderChapter

    }
}
