#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/1/30 22:54:50
* 文件名：Read_Site
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
    public class Read_SiteManager : BaseManager<Read_SiteManager, Read_Site>
    {

        public void UpdateSite(Read_Site readSite)
        {
            using (UpdateAction action = new UpdateAction(Entity))
            {
                action.SqlKeyValue(Read_Site.Columns.IsActive, 1);
                action.SqlKeyValue(Read_Site.Columns.IsSplider, 1);
                action.SqlKeyValue(Read_Site.Columns.LastSplider, DateTime.Now);
                action.SqlWhere(Read_Site.Columns.ID, readSite.ID);
                action.Excute();
            }
        }
    }
}
