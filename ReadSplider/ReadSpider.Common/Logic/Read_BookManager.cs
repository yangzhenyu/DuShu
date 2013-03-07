#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/2/27 23:06:27
* 文件名：Read_BookManager
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
    public class Read_BookManager : BaseManager<Read_BookManager, Read_Book>
    {
        public void UpdateBook(Read_Book readBook)
        {
            using (UpdateAction action = new UpdateAction(Entity))
            {
                action.SqlKeyValue(Read_Book.Columns.LastChapteID, readBook.LastChapteID);
                action.SqlWhere(Read_Book.Columns.BookID, readBook.BookID);
                action.Excute();
            }
        }
        public void InsertList(Dictionary<int, Read_Book> books)
        {
            List<string> sList = new List<string>();
            using (TradAction action = new TradAction())
            {
                foreach (var readBook in books)
                {
                    using (InserAction inserAction = new InserAction(readBook.Value))
                    {
                        sList.Add(inserAction.CreateSql(OperateEnum.Insert));
                    }

                }
                action.ExecuteSqlTran(sList);
            }
        }

        public List<Read_Book> GetBooks(int pagecount)
        {
            AppContent.Current.ReadSet();
            Setting setting = AppContent.Current.currentSetting;
            using (SelectAction action = new SelectAction(Entity))
            {
                action.SqlPageParms(pagecount);
                action.SqlWhere(Read_Book.Columns.IsSerialize, 1);
                if (setting.SpiderBookFrom < setting.LastBook)
                    action.SqlWhere(Read_Book.Columns.ID, setting.LastBook, RelationEnum.Large);
                else if (setting.SpiderBookFrom > 0)
                {
                    action.SqlWhere(Read_Book.Columns.ID, setting.SpiderBookFrom, RelationEnum.Large);
                }
                if (setting.SpiderBookTo > 0)
                    action.SqlWhere(Read_Book.Columns.ID, setting.SpiderBookTo, RelationEnum.LessThen);
                action.SqlOrderBy(Read_Book.Columns.ID, OrderByEnum.Desc);
                return action.QueryPage<Read_Book>(1);
            }
        }

        public List<int> GetBookIds(int siteID)
        {
            List<int> ids = new List<int>();
            using (SelectAction action = new SelectAction(Entity))
            {
                action.SqlPageParms(-1);
                action.SqlWhere(Read_Book.Columns.SiteID, siteID);
                List<Read_Book> books = action.QueryPage<Read_Book>(0);
                foreach (var book in books)
                {
                    ids.Add(book.BookID.Value);
                }
            }
            return ids;
        }
    }
}
