#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2012/12/30 22:14:56
* 文件名：ContentModel
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

namespace ReadSpider.Common.Model
{
    public class BooktModel
    {
        /// <summary>
        /// 书本的名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 书本ID
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// 最后更新的id
        /// </summary>
        public int LastChapterId { get; set; }
        /// <summary>
        /// 插件的ID
        /// </summary>
        public int PluginId { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 文章总字数
        /// </summary>
        public int BookLength { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string BookType { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Brief { get; set; }
    }

}
