#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/2/27 23:06:49
* 文件名：Read_ChapterManager
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
using HelloData.FrameWork.Data;
using ReadSpider.Common.Model;

namespace ReadSpider.Common.Logic
{
    public class Read_ChapterManager : BaseManager<Read_ChapterManager, Read_Chapter>
    {

        public void InsertList(List<Read_Chapter> chapters)
        {
            List<string> sList = new List<string>();
            using (TradAction action = new TradAction())
            {
                foreach (var readChapter in chapters)
                {
                    using (InserAction inserAction = new InserAction(readChapter))
                    {
                        sList.Add(inserAction.CreateSql(OperateEnum.Insert));
                    }

                }
                action.ExecuteSqlTran(sList);
            }
        }

        public void UpdateList(List<Read_Chapter> chapters)
        {
            StringBuilder sList = new StringBuilder();
            using (TradAction action = new TradAction())
            {
                foreach (var readChapter in chapters)
                {
                    using (UpdateAction updateAction = new UpdateAction(readChapter))
                    {
                        updateAction.SqlWhere(Read_Chapter.Columns.ID, readChapter.ID);
                        updateAction.SqlKeyValue(Read_Chapter.Columns.ChapterContent, readChapter.ChapterContent);
                        updateAction.SqlKeyValue(Read_Chapter.Columns.IsSpilder, 1);
                        updateAction.SqlKeyValue(Read_Chapter.Columns.UpdateDate, DateTime.Now);
                        sList.AppendLine(updateAction.CreateSql(OperateEnum.Update));
                    }
                }
                action.Excute(sList.ToString());
            }
        }

        public List<Read_Chapter> GetChapters(int pagecount)
        {
            AppContent.Current.ReadSet();
            Setting setting = AppContent.Current.currentSetting;
            using (SelectAction action = new SelectAction(Entity))
            {
                action.SqlPageParms(pagecount);
                action.SqlWhere(Read_Chapter.Columns.IsSpilder, 0);
                if (setting.SpiderChapterFrom < setting.LastChapter)
                    action.SqlWhere(Read_Chapter.Columns.ID, setting.LastChapter, RelationEnum.Large);
                else if (setting.SpiderChapterFrom > 0)
                {
                    action.SqlWhere(Read_Chapter.Columns.ID, setting.SpiderChapterFrom, RelationEnum.Large);
                }
                if (setting.SpiderChapterTo > 0)
                    action.SqlWhere(Read_Chapter.Columns.ID, setting.SpiderChapterTo, RelationEnum.LessThen);
                action.SqlOrderBy(Read_Chapter.Columns.ID, OrderByEnum.Desc);
                return action.QueryPage<Read_Chapter>(1);
            }
        }
    }
}
