#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2012/12/30 22:36:21
* 文件名：BookManager
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

namespace ReadSpider.Common.Logic
{
    public class BookManager : BaseManager<BookManager, Book>
    {
        public BookManager()
        {
            this.Entity = new Book();
        }

        public bool HasBook(int resourceid, int pluginid)
        {
            using (SelectAction action = new SelectAction(Entity))
            {
                action.SqlClomns = "count(1)";
                action.SqlWhere(Book.Columns.PluginID, pluginid);
                action.SqlWhere(Book.Columns.ResourceID, resourceid);
                return ((int)action.QuerySingle()) > 0;
            }
        }
        public int SaveIDENTITY(Book model)
        {
            using (InserAction insert = new InserAction(model))
            {
                insert.ExcuteIdentity();
                return insert.ReturnCode;
            }
        }
    }
}
