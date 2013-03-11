#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/2/27 22:51:16
* 文件名：Read_Book
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

//namespace ReadSpider.Common.Model

public partial class Read_Book
{
    [Column(NoSqlProperty = true)]
    public string ChapterReg { get; set; }
    [Column(NoSqlProperty = true)]
    public string ContentUrl { get; set; }
}

