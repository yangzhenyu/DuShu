namespace MyBatisTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.t_connstring = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sel_tabs = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.t_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_temp = new System.Windows.Forms.ComboBox();
            this.dao = new System.Windows.Forms.TextBox();
            this.bll = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BLLText = new System.Windows.Forms.TextBox();
            this.DAOtext = new System.Windows.Forms.TextBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.objectText = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "字符串：";
            // 
            // t_connstring
            // 
            this.t_connstring.Location = new System.Drawing.Point(272, 16);
            this.t_connstring.Name = "t_connstring";
            this.t_connstring.Size = new System.Drawing.Size(777, 21);
            this.t_connstring.TabIndex = 1;
            this.t_connstring.Text = "Data Source=(local);Initial Catalog=DuShu;uid=sa;password=password;";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sel_tabs
            // 
            this.sel_tabs.AutoSize = true;
            this.sel_tabs.Location = new System.Drawing.Point(12, 21);
            this.sel_tabs.Name = "sel_tabs";
            this.sel_tabs.Size = new System.Drawing.Size(60, 16);
            this.sel_tabs.TabIndex = 4;
            this.sel_tabs.Text = "所有表";
            this.sel_tabs.UseVisualStyleBackColor = true;
            this.sel_tabs.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(176, 626);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "生成";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(605, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // t_code
            // 
            this.t_code.Location = new System.Drawing.Point(724, 154);
            this.t_code.Multiline = true;
            this.t_code.Name = "t_code";
            this.t_code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.t_code.Size = new System.Drawing.Size(159, 469);
            this.t_code.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(682, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "目前只支持MsSql数据库";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(219, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "选择模板：";
            // 
            // cbx_temp
            // 
            this.cbx_temp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_temp.FormattingEnabled = true;
            this.cbx_temp.Location = new System.Drawing.Point(288, 47);
            this.cbx_temp.Name = "cbx_temp";
            this.cbx_temp.Size = new System.Drawing.Size(160, 20);
            this.cbx_temp.TabIndex = 15;
            // 
            // dao
            // 
            this.dao.Location = new System.Drawing.Point(354, 154);
            this.dao.Multiline = true;
            this.dao.Name = "dao";
            this.dao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dao.Size = new System.Drawing.Size(183, 469);
            this.dao.TabIndex = 8;
            // 
            // bll
            // 
            this.bll.Location = new System.Drawing.Point(182, 154);
            this.bll.Multiline = true;
            this.bll.Name = "bll";
            this.bll.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bll.Size = new System.Drawing.Size(166, 469);
            this.bll.TabIndex = 8;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(536, 154);
            this.model.Multiline = true;
            this.model.Name = "model";
            this.model.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.model.Size = new System.Drawing.Size(182, 469);
            this.model.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bll命名空间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "DAO命名空间:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(682, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "Model命名空间:";
            // 
            // BLLText
            // 
            this.BLLText.Location = new System.Drawing.Point(265, 77);
            this.BLLText.Name = "BLLText";
            this.BLLText.Size = new System.Drawing.Size(147, 21);
            this.BLLText.TabIndex = 17;
            this.BLLText.Text = "DuShu.BLL";
            // 
            // DAOtext
            // 
            this.DAOtext.Location = new System.Drawing.Point(510, 76);
            this.DAOtext.Name = "DAOtext";
            this.DAOtext.Size = new System.Drawing.Size(147, 21);
            this.DAOtext.TabIndex = 18;
            this.DAOtext.Text = "DuShu.DAO";
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(777, 76);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(147, 21);
            this.ModelText.TabIndex = 18;
            this.ModelText.Text = "DuShu.Model";
            // 
            // objectText
            // 
            this.objectText.Location = new System.Drawing.Point(889, 154);
            this.objectText.Multiline = true;
            this.objectText.Name = "objectText";
            this.objectText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.objectText.Size = new System.Drawing.Size(160, 469);
            this.objectText.TabIndex = 8;
            // 
            // table
            // 
            this.table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table.FormattingEnabled = true;
            this.table.Location = new System.Drawing.Point(265, 113);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(160, 20);
            this.table.TabIndex = 15;
            this.table.SelectedIndexChanged += new System.EventHandler(this.table_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 626);
            this.Controls.Add(this.ModelText);
            this.Controls.Add(this.DAOtext);
            this.Controls.Add(this.BLLText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.table);
            this.Controls.Add(this.cbx_temp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bll);
            this.Controls.Add(this.objectText);
            this.Controls.Add(this.model);
            this.Controls.Add(this.dao);
            this.Controls.Add(this.t_code);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.sel_tabs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_connstring);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MyCode V1.0 【Stone】";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_connstring;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox sel_tabs;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox t_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_temp;
        private System.Windows.Forms.TextBox dao;
        private System.Windows.Forms.TextBox bll;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BLLText;
        private System.Windows.Forms.TextBox DAOtext;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.TextBox objectText;
        private System.Windows.Forms.ComboBox table;
    }
}

