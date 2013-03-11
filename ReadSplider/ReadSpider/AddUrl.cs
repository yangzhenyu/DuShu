using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadSpider
{
    public partial class AddUrl : Form
    {
        public AddUrl()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        public bool isSpiderAll = false;
        public Read_Site site = new Read_Site();
        private void button1_Click(object sender, EventArgs e)
        {
            site.SiteName = textBox6.Text;
            site.SiteUrl = textBox1.Text;
            site.BookReg = textBox2.Text;
            site.ChapterUrl = textBox3.Text;
            site.IsSeriesReg = textBox4.Text;
            site.BookWriter = textBox5.Text;
            isSpiderAll = checkBox1.Checked;
            site.BookRegIndex = int.Parse(textBox9.Text);
            site.ChapterRegIndex = int.Parse(textBox10.Text);
            site.ContentReg = textBox8.Text;
            site.ContentRegIndex = int.Parse(textBox11.Text);
            site.ChapterReg = textBox12.Text;
            site.ContentUrl = textBox13.Text;
            site.IsNotSplideParms = checkBox1.Checked;
            site.SpliderDeep = int.Parse(comboBox1.SelectedText);

            this.DialogResult = DialogResult.OK;
        }
    }
}
