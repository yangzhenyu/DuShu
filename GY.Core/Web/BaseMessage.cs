using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;


namespace GY.Core.Web
{
     /// <summary>
    /// Web 消息辅助类.
    /// </summary>
    public static class BaseMessage
    { 
        /// <summary>
        /// 应用程序路径.
        /// </summary>
        public  static string AppPath
        {
            get { return WebUtils.AppPath(); }
        }
    }
}
