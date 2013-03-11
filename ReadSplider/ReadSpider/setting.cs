using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HelloData.FWCommon.Utils;
using ReadSpider.Common;
using ReadSpider.Common.Model;

namespace ReadSpider
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniHelper helper = new IniHelper(AppDomain.CurrentDomain.BaseDirectory.ToString() + "setting.ini");
            helper.IniWriteValue("setting", "bookread", numericUpDown2.Value.ToString());
            helper.IniWriteValue("setting", "chapterread", numericUpDown3.Value.ToString());
            helper.IniWriteValue("setting", "siteread", numericUpDown1.Value.ToString());

            helper.IniWriteValue("setting", "bookfrom", textBox1.Text);
            helper.IniWriteValue("setting", "bookto", textBox2.Text);

            helper.IniWriteValue("setting", "chapterfrom", textBox4.Text);
            helper.IniWriteValue("setting", "chapterto", textBox3.Text);

            AppContent.Current.ReadSet();
            this.Close();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            numericUpDown2.Value = AppContent.Current.currentSetting.SpiderBook;
            numericUpDown3.Value = AppContent.Current.currentSetting.SpiderChapter;
            numericUpDown1.Value = AppContent.Current.currentSetting.SpiderOutTime;

            textBox1.Text = AppContent.Current.currentSetting.SpiderBookFrom.ToString();
            textBox2.Text = AppContent.Current.currentSetting.SpiderBookTo.ToString();

            textBox3.Text = AppContent.Current.currentSetting.SpiderChapterTo.ToString();
            textBox4.Text = AppContent.Current.currentSetting.SpiderChapterFrom.ToString();

        }
    }
}
