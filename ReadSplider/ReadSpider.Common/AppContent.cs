#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2012/12/30 22:28:42
* 文件名：AppContent
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
using System.Configuration;
using System.Linq;
using System.Text;
using HelloData.FWCommon.Utils;
using HelloData.FrameWork;
using HelloData.FrameWork.Cache;
using HelloData.FrameWork.Data;
using HelloData.FrameWork.Logging;
using ReadSpider.Common.Model;

namespace ReadSpider.Common
{
    /// <summary>
    /// 所有的程序调用时的数据库的接口跟应用程序的接口
    /// </summary>
    public class AppContent
    {
        static AppContent()
        {

            Current = new AppContent();
        }

        public static AppContent Current { get; private set; }

        public static List<Read_Site> AllSites { get; set; }

        public void ReadSet()
        {
            IniHelper helper = new IniHelper(AppDomain.CurrentDomain.BaseDirectory.ToString() + "setting.ini");

            Setting set = new Setting();
            set.SpiderBook = int.Parse(helper.IniReadValue("setting", "bookread"));
            set.SpiderChapter = int.Parse(helper.IniReadValue("setting", "chapterread"));
            set.SpiderOutTime = int.Parse(helper.IniReadValue("setting", "siteread"));

            set.SpiderBookFrom = int.Parse(helper.IniReadValue("setting", "bookfrom"));
            set.SpiderBookTo = int.Parse(helper.IniReadValue("setting", "bookto"));

            set.SpiderChapterFrom = int.Parse(helper.IniReadValue("setting", "chapterfrom"));
            set.SpiderChapterTo = int.Parse(helper.IniReadValue("setting", "chapterto"));


            set.LastBook = int.Parse(helper.IniReadValue("setting", "lastbook"));
            set.LastChapter = int.Parse(helper.IniReadValue("setting", "lastchapter"));

            set.LastBookDate = DateTime.Parse(helper.IniReadValue("setting", "lastbookdate"));
            set.LastChapterDate = DateTime.Parse(helper.IniReadValue("setting", "lastchapterdate"));
            currentSetting = set;
        }

        public Setting currentSetting { get; set; }

        public void Init()
        {
            //启动日志模块
            Logger.Current.SetLogger = new LogNet();
            Logger.Current.IsOpenLog = true;
            Logger.CurrentLog.Info("INSTALLING");

            //设置数据库连接执行状况
            AppCons.LogSqlExcu = true;
            //设置第一个数据库
            AppCons.SetDefaultConnect(new MsSqlHelper(), ConfigurationManager.AppSettings["ConnectionString"]);
            //是否需要数据库全局参数化
            AppCons.IsParmes = false;
            //是否数据库操作的缓存
            AppCons.IsOpenCache = false;
        }
    }
}
