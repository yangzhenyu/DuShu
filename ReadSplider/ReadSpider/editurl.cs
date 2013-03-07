using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReadSpider.Common.Logic;

namespace ReadSpider
{
    public partial class editurl : Form
    {
        public editurl()
        {
            InitializeComponent();
        }

        public int siteid { get; set; }

        private void editurl_Load(object sender, EventArgs e)
        {
            Read_Site site = Read_SiteManager.Instance.Get(siteid);
            textBox6.Text = site.SiteName;
            textBox1.Text = site.SiteUrl;
            textBox2.Text = site.BookReg;
            textBox3.Text = site.ChapterUrl;
            textBox4.Text = site.IsSeriesReg;
            textBox5.Text = site.BookWriter;
            textBox9.Text = site.BookRegIndex.ToString();
            textBox10.Text = site.ChapterRegIndex.ToString();
            textBox8.Text = site.ContentReg;
            textBox11.Text = site.ContentRegIndex.ToString();
            textBox12.Text = site.ChapterReg;
            textBox13.Text = site.ContentUrl;
            checkBox1.Checked = site.IsNotSplideParms.Value;
            comboBox1.SelectedIndex = site.SpliderDeep.Value - 1;

        }
        public Read_Site rsite = new Read_Site();
        private void button1_Click(object sender, EventArgs e)
        {
            rsite.SiteName = textBox6.Text;
            rsite.SiteUrl = textBox1.Text;
            rsite.BookReg = textBox2.Text;
            rsite.ChapterUrl = textBox3.Text;
            rsite.IsSeriesReg = textBox4.Text;
            rsite.BookWriter = textBox5.Text;
            rsite.BookRegIndex = int.Parse(textBox9.Text);
            rsite.ChapterRegIndex = int.Parse(textBox10.Text);
            rsite.ContentReg = textBox8.Text;
            rsite.ContentRegIndex = int.Parse(textBox11.Text);
            rsite.ChapterReg = textBox12.Text;
            rsite.ContentUrl = textBox13.Text;
            rsite.IsNotSplideParms = checkBox1.Checked;
            rsite.SpliderDeep = comboBox1.SelectedIndex+1;
            rsite.ID = siteid;
            this.DialogResult = DialogResult.OK;
        }
    }
}
