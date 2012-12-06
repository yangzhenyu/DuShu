using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Web.UI;

namespace GY.Core.Web
{
    /// <summary>
    /// 模板页基础类.
    /// </summary>
    public class BaseMasterPage : MasterPage
    {
        /// <summary>
        /// 应用程序路径.
        /// </summary>
        protected static string AppPath
        {
            get { return WebUtils.AppPath(); }
        }
    }
}
