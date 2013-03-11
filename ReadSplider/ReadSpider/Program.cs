using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ReadSpider.Common;

namespace ReadSpider
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContent content = new AppContent();
            content.Init();
            Application.Run(new MainForm());
          
        }
    }
}
