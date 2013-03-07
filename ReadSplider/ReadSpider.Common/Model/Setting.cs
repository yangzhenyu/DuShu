#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/1/31 13:59:30
* 文件名：Setting
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
    public class Setting
    {
        /// <summary>
        /// 书本扫描的间隔时间
        /// </summary>
        public int SpiderBook { get; set; }
        /// <summary>
        /// 章节扫描的间隔时间
        /// </summary>
        public int SpiderChapter { get; set; }
        /// <summary>
        /// 全网扫描超时时间
        /// </summary>
        public int SpiderOutTime { get; set; }


        public int SpiderBookFrom { get; set; }
        public int SpiderBookTo { get; set; }


        public int SpiderChapterFrom { get; set; }
        public int SpiderChapterTo { get; set; }


        public int LastBook { get; set; }
        public int LastChapter { get; set; }

        public DateTime LastBookDate { get; set; }
        public DateTime LastChapterDate { get; set; }

        public Setting()
        {
            SpiderBook = 5;
            SpiderChapter = 3;
            SpiderOutTime = 5;

            SpiderBookFrom = -1;
            SpiderBookTo = -1;


            SpiderChapterFrom = -1;
            SpiderChapterTo = -1;
        }
    }
}
