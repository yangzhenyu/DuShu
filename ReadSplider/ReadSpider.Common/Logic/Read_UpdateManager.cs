#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/3/3 21:41:53
* 文件名：Read_UpdateManager
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
using System.Text;
using HelloData.FWCommon.Utils;
using HelloData.FrameWork.Data;

namespace ReadSpider.Common.Logic
{
    public class Read_UpdateManager : BaseManager<Read_UpdateManager, Read_Update>
    {

        public void UpdateDate()
        {
            AppContent.Current.ReadSet();
            if (AppContent.Current.currentSetting.LastBookDate < DateTime.Now.Date)
            {
                IniHelper helper = new IniHelper(AppDomain.CurrentDomain.BaseDirectory.ToString() + "setting.ini");
                helper.IniWriteValue("setting", "lastbook", "0");
                helper.IniWriteValue("setting", "lastchapter", "0");
                helper.IniWriteValue("setting", "lastbookdate", DateTime.Now.ToString());

                helper.IniWriteValue("setting", "lastchapterdate", DateTime.Now.ToString());
            }

            //using (UpdateAction action = new UpdateAction(Entity))
            //{
            //    action.SqlWhere(Read_Update.Columns.LastBookDate, DateTime.Now.Date, RelationEnum.Less);
            //    action.SqlKeyValue(Read_Update.Columns.LastBook, 0);
            //    action.SqlKeyValue(Read_Update.Columns.LastChapter, 0);
            //    action.SqlKeyValue(Read_Update.Columns.LastBookDate, DateTime.Now);
            //    action.SqlKeyValue(Read_Update.Columns.LastChapterDate, DateTime.Now);
            //    action.Excute();
            //}
        }
        public void UpdateBook(int bookid)
        {
            IniHelper helper = new IniHelper(AppDomain.CurrentDomain.BaseDirectory.ToString() + "setting.ini");
            helper.IniWriteValue("setting", "lastbook", bookid.ToString());
            //using (UpdateAction action = new UpdateAction(Entity))
            //{
            //    action.SqlKeyValue(Read_Update.Columns.LastBook, bookid);
            //    action.SqlKeyValue(Read_Update.Columns.LastChapterDate, DateTime.Now);
            //    action.Excute();
            //}
        }
        public void UpdateChapter(int chapterid)
        {
            IniHelper helper = new IniHelper(AppDomain.CurrentDomain.BaseDirectory.ToString() + "setting.ini");
            helper.IniWriteValue("setting", "lastchapter", chapterid.ToString());
            //using (UpdateAction action = new UpdateAction(Entity))
            //{
            //    action.SqlKeyValue(Read_Update.Columns.LastChapter, chapterid);
            //    action.SqlKeyValue(Read_Update.Columns.LastChapterDate, DateTime.Now);
            //    action.Excute();
            //}
        }

        internal Read_Update GetModel()
        {
            Read_Update update = new Read_Update();
            IniHelper helper = new IniHelper(AppDomain.CurrentDomain.BaseDirectory.ToString() + "setting.ini");
            update.LastBook = int.Parse(helper.IniReadValue("setting", "lastbook"));
            update.LastBook = int.Parse(helper.IniReadValue("setting", "lastchapter"));
            return update;
        }
    }
}
