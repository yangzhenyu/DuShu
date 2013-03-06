#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/3/5 23:59:30
* 文件名：HandlerResult
* 版本：V1.0.1
* 联系方式：511522329  
*
* 修改者： 时间： 
* 修改说明：
* ========================================================================
*/
#endregion

using System;
using Newtonsoft.Json;

namespace DuShu.Web.Code
{
    public class HandlerResult
    {
        public HandlerResult()
        {
            PostTime = DateTime.Now;
        }
        /// <summary>
        ///   结果
        /// </summary>
        public int Result { get; set; }
        /// <summary>
        /// 结果信息（可存放实体类等）
        /// </summary>
        public object Message { get; set; }
        public new string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        /// <summary>
        /// 执行时间
        /// </summary>
        public DateTime PostTime
        {
            get;
            set;
        }

        public HandlerResult DefaultResult()
        {
            return new HandlerResult() { Result = 0, Message = "当前请求处理失败" };
        }
    }
}
