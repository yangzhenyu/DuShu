using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.IO;
using System.Web;

namespace MyBatisTools
{
    public partial class Form1 : Form
    {
        private String ConnString = String.Empty;   // 链接字符串
        private string T_infodata = String.Empty;   // 需要替换模板内容的动态标签
        private string T_template = String.Empty;   // 模板的内容
        private string T_format = String.Empty;     // 生成类的文件名

        private string template = String.Empty;
        private string templateModel = String.Empty;
        private string templateBll = String.Empty;
        private string templateBllInterface = String.Empty;
        private string templateDao = String.Empty;
        private string templateDaoInterface = String.Empty;
        private string templateObject = String.Empty;  
         
        public Form1()
        {
            InitializeComponent();
        }

        // 连接按钮事件
        private void button1_Click(object sender, EventArgs e)
        {
            ConnString = t_connstring.Text.Trim();
            if (button1.Text == "断开")
            {
                listView1.Controls.Clear();
                sel_tabs.Checked = false;
                t_code.Text = "";
                button1.Text = "连接";
            }
            else
            {
                if (String.IsNullOrEmpty(ConnString))
                {
                    MessageBox.Show("数据库连接字符串不能为空！");
                    return;
                }
                // 所有表名
                DataTable allTable = GetDataTableBySql("select table_name from information_schema.key_column_usage ");
                listView1.Controls.Clear();
                for (int i = 0; i < allTable.Rows.Count; i++)
                {
                    CheckBox cb = new CheckBox();
                    cb.Text = allTable.Rows[i][0].ToString();
                    cb.Top = i * 20;
                    listView1.Controls.Add(cb);
                }
                button1.Text = "断开";
            }
        }

        // all Tables CheckBox 属性更改事件
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in listView1.Controls)
            {
                ((CheckBox)item).Checked = sel_tabs.Checked;
            }
        }

        // wf 窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_temp.Items.Insert(0, "请选择");
            cbx_temp.SelectedIndex = 0;
            string templatePath = "Template";   // 模板地址
            int counter = 0;
            foreach (string item in Directory.GetFiles(templatePath))
            {
                cbx_temp.Items.Insert(++counter, item.Replace(@"Template\", ""));
            }
        }

        #region 读取文件
        public static byte[] ReadFully(Stream stream)
        {
            // 初始化一个32k的缓存  
            byte[] buffer = new byte[32768];
            using (MemoryStream ms = new MemoryStream())
            { //返回结果后会自动回收调用该对象的Dispose方法释放内存  
                // 不停的读取  
                while (true)
                {
                    int read = stream.Read(buffer, 0, buffer.Length);
                    // 直到读取完最后的3M数据就可以返回结果了  
                    if (read <= 0)
                        return ms.ToArray();
                    ms.Write(buffer, 0, read);
                }
            }
        }
        #endregion

        #region 根据sql返回数组
        public DataTable GetDataTableBySql(string sql)
        {
            SqlDataAdapter da = null;
            DataTable tab = new DataTable();
            using (SqlConnection Conn = new SqlConnection(ConnString))
            {
                try
                {
                    da = new SqlDataAdapter(sql, Conn);
                    da.Fill(tab);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    da.SelectCommand.Parameters.Clear();
                }
                return tab;
            }
        }
        #endregion

        // 保存按钮事件
        private void button3_Click(object sender, EventArgs e)
        {
            //if ("" == t_code.Text.Trim() || T_format.IndexOf(".") < 0)
            //{
            //    MessageBox.Show("请先生成代码！");
            //    return;
            //}

            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "(*.xml)|*.xml|All Files|*.*";
            //saveFileDialog1.FileName = T_format.Substring(0, T_format.IndexOf("."));
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    StreamWriter sTmp = new StreamWriter(saveFileDialog1.FileName); //saveFileDialog1.FileName @"C:\Users\Stone_W\Desktop\MyCode使用简介.txt"
            //    sTmp.WriteLine(t_code.Text);
            //    sTmp.Flush();
            //    sTmp.Close();
            //}
            foreach (Control item in listView1.Controls)
            {
                CheckBox thisItem = ((CheckBox)item);
                if (thisItem.Checked)
                {
                   saveTemplate(thisItem.Text.Trim(), true); 
                }
            }
            MessageBox.Show("生成成功!");

        }

        private string getModelString(string name ,string typename)
        {
             
            if (typename == "uniqueidentifier")
            {
                typename = " Guid " ;
               
            }
            else if (typename == "decimal")
            {
                typename = " Decimal "; 
            }

            else if (typename == "int")
            {
                typename = " Int32 "; 
            }
            else if (typename == "datetime")
            {
                typename = " DateTime ";  
            }
            else {

                typename = " String ";
            }
            return  "    /// <summary>\n" +
                    "    /// \n" +
                    "    /// <summary>\n" +
                    "    public " + typename + " " + name + " \n" +
                    "    {\n" +
                      "     get; \n" +
                      "     set;\n" +
                    "    }\n" +
                    "\n" +
                    "";

           
        }

        // 点击生成按钮
        private void button2_Click(object sender, EventArgs e)
        {
           
            table.Items.Clear();
            table.Items.Insert(0, "请选择");
            table.SelectedIndex = 0;
            int counter = 0;
          
            bool sign = false;  // table 使用标记
            foreach (Control item in listView1.Controls)
            {
                CheckBox thisItem = ((CheckBox)item);
                if (thisItem.Checked)
                {
                    sign = true;
                    counter++;
                    table.Items.Insert(counter, thisItem.Text.Trim());
                    if (counter == 1)
                    {
                        table.SelectedText = thisItem.Text.Trim();
                        saveTemplate(thisItem.Text.Trim(), false);
                    }
                }
            }
           
            if (!sign)
            { 
                table.SelectedIndex = 0;
                MessageBox.Show("请选择要生成的表！");
                return;
            }
        }
         
        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {      
                t_code.Text = "";
                model.Text = "";
                bll.Text = "";
                bll.Text = "";
                dao.Text = "";
                dao.Text = "";
                objectText.Text = "";
            if (table.SelectedIndex != 0)
            {
                Object selectedItem = table.SelectedItem; 
                //ComboBox ss = (ComboBox)table.Items[table.SelectedIndex];
               //CheckBox thisItem = ((CheckBox)table.Items[table.SelectedIndex]);
                saveTemplate(selectedItem.ToString().Trim(), false); 
            } 
        }

        private void saveValue(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        } 

        private void saveFile(string path,string context)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllText(path, context);
        }

        private void saveTemplate(string tableName, bool save)
        {
           
            string templatePath = @"Template\" + cbx_temp.Text;
            string templatePathModel = @"Template\" + cbx_temp.Text + ".model";
            string templatePathBll = @"Template\" + cbx_temp.Text + ".Bll";
            string templatePathBllInterface = @"Template\" + cbx_temp.Text + ".Bll.Interface";
            string templatePathDao = @"Template\" + cbx_temp.Text + ".Dao";
            string templatePathDaoInterface = @"Template\" + cbx_temp.Text + ".Dao.Interface";
            string templatePathObject = @"Template\" + cbx_temp.Text + ".Object";
            if (cbx_temp.Text.Contains("请选择"))
            {
                MessageBox.Show("请先选择模板！");
                return;
            }

            #region 模板相关信息
            // 模板配置文件
            template = System.Text.Encoding.Default.GetString(
                ReadFully((new StreamReader(templatePath).BaseStream)));
            templateModel = System.Text.Encoding.Default.GetString(
                ReadFully((new StreamReader(templatePathModel).BaseStream)));
            templateBll = System.Text.Encoding.Default.GetString(
                ReadFully((new StreamReader(templatePathBll).BaseStream)));
            templateBllInterface = System.Text.Encoding.Default.GetString(
                ReadFully((new StreamReader(templatePathBllInterface).BaseStream)));
            templateDao = System.Text.Encoding.Default.GetString(
                ReadFully((new StreamReader(templatePathDao).BaseStream)));
            templateDaoInterface = System.Text.Encoding.Default.GetString(
                ReadFully((new StreamReader(templatePathDaoInterface).BaseStream)));
            templateObject = System.Text.Encoding.Default.GetString(
                           ReadFully((new StreamReader(templatePathObject).BaseStream)));




            if (!String.IsNullOrEmpty(template) && template.Contains("T_format")
                && template.Contains("T_template") && template.Contains("T_infodata"))
            {
                T_format =       // 生成类的文件名
                    template.Substring((template.IndexOf("T_format:") + "T_format:".Length),
                    (template.IndexOf("\r\n") - 7));
                T_template =     // 模板的内容
                    template.Substring((template.IndexOf("T_template:") + "T_template:".Length),
                    (template.IndexOf("T_infodata:") - (template.IndexOf("T_template:") + "T_template:".Length)));

                T_infodata =     // 需要替换模板内容的动态标签
                    template.Substring((template.IndexOf("T_infodata:") + "T_infodata:".Length),
                    (template.LastIndexOf("|") - (template.IndexOf("T_infodata:") + "T_infodata:".Length))); ;
            }
            else
            {
                MessageBox.Show("模板格式有误！");
                return;
            }
            templateModel = templateModel.Replace("$modelNamespace", ModelText.Text.ToString().Trim());
            templateBll = templateBll.Replace("$modelNamespace", ModelText.Text.ToString().Trim());
            templateBllInterface = templateBllInterface.Replace("$modelNamespace", ModelText.Text.ToString().Trim());
            templateDao = templateDao.Replace("$modelNamespace", ModelText.Text.ToString().Trim());
            templateDaoInterface = templateDaoInterface.Replace("$modelNamespace", ModelText.Text.ToString().Trim());
            templateObject = templateObject.Replace("$modelNamespace", ModelText.Text.ToString().Trim());

            #endregion

            #region [更换]
            //string tableName = //thisItem.Text;   // 表名
            string pk = String.Empty;           // 主键
            StringBuilder insert = new StringBuilder();     // 添加语句
            StringBuilder update = new StringBuilder();     // 修改语句
            StringBuilder tableMapInfoResult = new StringBuilder();
            StringBuilder where = new StringBuilder();
            StringBuilder modelString = new StringBuilder();
            StringBuilder daoString = new StringBuilder();
            StringBuilder bllString = new StringBuilder();
            Array tablenameArray = tableName.Split('_');
            string tableMap = tablenameArray.Length > 1 ? tablenameArray.GetValue(1).ToString() : tableName;
            string theLowerKey = tableMap.Substring(0, 1).ToLower();
            string theUpperKey = tableMap.Substring(0, 1).ToUpper();
            tableMap = theUpperKey + tableMap.Substring(1, tableMap.Length - 1).ToLower();
            string stableMap = theLowerKey + tableMap.Substring(1, tableMap.Length - 1).ToLower();
            string className = ModelText.Text.Trim() + "." + tableMap;
            string T_namespace = ModelText.Text.Trim();
            T_format = T_format.Replace("$tableMap", tableMap);
            T_template = T_template.Replace("$namespace", T_namespace);
            T_template = T_template.Replace("$className", className);
            T_template = T_template.Replace("$tableMap", tableMap);
            T_template = T_template.Replace("$table", tableName);
            templateModel = templateModel.Replace("$tableMap", tableMap);

            templateBll = templateBll.Replace("$tableMap", tableMap).Replace("$stableMap", stableMap);
            templateBllInterface = templateBllInterface.Replace("$tableMap", tableMap).Replace("$stableMap", stableMap);
            templateDao = templateDao.Replace("$tableMap", tableMap);
            templateDaoInterface = templateDaoInterface.Replace("$tableMap", tableMap);
            templateObject = templateObject.Replace("$tableMap", tableMap);





            templateBll = templateBll.Replace("$BllName", BLLText.Text.ToString().Trim());
            templateBllInterface = templateBllInterface.Replace("$BllName", BLLText.Text.ToString().Trim());
            templateDao = templateDao.Replace("$BllName", BLLText.Text.ToString().Trim());
            templateDaoInterface = templateDaoInterface.Replace("$BllName", BLLText.Text.ToString().Trim());
            templateObject = templateObject.Replace("$BllName", BLLText.Text.ToString().Trim());


            templateBll = templateBll.Replace("$DaoName", DAOtext.Text.ToString().Trim());
            templateBllInterface = templateBllInterface.Replace("$DaoName", DAOtext.Text.ToString().Trim());
            templateDao = templateDao.Replace("$DaoName", DAOtext.Text.ToString().Trim());
            templateDaoInterface = templateDaoInterface.Replace("$DaoName", DAOtext.Text.ToString().Trim());
            templateObject = templateObject.Replace("$DaoName", DAOtext.Text.ToString().Trim());


            // 主键查询
            DataTable pk_dt = GetDataTableBySql(String.Format("select column_name as filed from information_schema.key_column_usage where table_name='{0}'",
                tableName));
            if (null != pk_dt && pk_dt.Rows.Count > 0)
            {
                pk = pk_dt.Rows[0][0].ToString();
            }

            DataTable column_dt = GetDataTableBySql(String.Format("sp_columns @table_name= '{0}'",
               tableName));
            if (null != column_dt && column_dt.Rows.Count > 0)
            {
                insert.Append(String.Format("INSERT INTO  {0}  VALUES(", tableName));
                update.Append("UPDATE " + tableName + " SET ");
                for (int i = 0; i < column_dt.Rows.Count; i++)
                {
                    string columnName = column_dt.Rows[i]["column_name"].ToString();
                    string typename = column_dt.Rows[i]["type_name"].ToString().Trim().ToLower();
                    if (!typename.Contains("identity"))
                    {
                        insert.Append(String.Format("#{0}#,", columnName));
                        if (columnName.ToLower() != pk.ToLower())
                        {
                            update.Append(String.Format("{0}=#{0}#,", columnName));
                        }

                    }
                    tableMapInfoResult.Append("          <result property=\"" + columnName + "\" column=\"" + columnName + "\"/>\n");
                    where.Append("           <isNotEmpty prepend=\"and\" property=\"" + columnName + "\">\n" +
                                       "            [" + columnName + "] = #" + columnName + "#" + "\n" +
                                      "          </isNotEmpty>\n");
                    modelString.Append(getModelString(columnName, typename));
                }
            }
            string insertSql = insert.ToString().TrimEnd(',') + ")";
            string updateSql = String.Format(update.ToString().TrimEnd(',') + " where {0}=#{0}#",
                pk);

            templateModel = templateModel.Replace("$tableColumns", modelString.ToString());
            T_template = T_template.Replace("$Info_Para", tableMapInfoResult.ToString());
            T_template = T_template.Replace("$where", where.ToString());
            T_template = T_template.Replace("$table", tableName).Replace("$id", pk).
                Replace("$insert", insertSql).Replace("$update", updateSql);
            #endregion [更换] 

            #region [保存或显示]
            if (save)
            {
                string saveBll = BLLText.Text.Trim();
                string saveBllInterface= BLLText.Text.Trim()+@"\Interface";
                string saveDAO = DAOtext.Text.Trim();
                string saveDAOInterface = DAOtext.Text.Trim() + @"\Interface";
                string saveModel = ModelText.Text.Trim();
                string saveSqlMap = "SqlMap";
                string saveObject = "Object";
                saveValue(saveBll);
                saveValue(saveBllInterface);
                saveValue(saveDAO);
                saveValue(saveDAOInterface);
                saveValue(saveModel);
                saveValue(saveSqlMap);
                saveValue(saveObject);
                saveFile(saveBll + @"\" + tableMap + "Service.cs", templateBll);
                saveFile(saveBllInterface + @"\I" + tableMap + "Service.cs", templateBllInterface);
                saveFile(saveDAO + @"\" + tableMap + "Dao.cs", templateDao);
                saveFile(saveDAOInterface + @"\I" + tableMap + "Dao.cs", templateDaoInterface);
                saveFile(saveModel + @"\" + tableMap + ".cs", templateModel);
                saveFile(saveSqlMap + @"\" + tableMap + ".config", T_template);
                saveFile(saveObject + @"\" + tableMap + ".config", templateObject);
            }
            else { 
            
            t_code.Text += T_template;
            model.Text += templateModel;
            bll.Text += templateBllInterface;
            bll.Text += templateBll;
            dao.Text += templateDaoInterface;
            dao.Text += templateDao;
            objectText.Text += templateObject;

            }
            #endregion [保存或显示]
        }
         

    }
}
