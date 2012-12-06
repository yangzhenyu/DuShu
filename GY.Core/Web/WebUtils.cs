using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Collections.Specialized;
namespace GY.Core.Web
{
    /// <summary>
    /// WebUtils 的摘要说明。
    /// </summary>
    public static class WebUtils
    {
        private static object o = new object();
        private static string appPath = null;

        /// <summary>
        /// 获取相对于站点根目录的应用程序路径
        /// </summary>
        /// <returns></returns>
        public static string AppPath()
        {
            if (null == appPath)
            {
                lock (o)
                {
                    appPath = HttpContext.Current.Request.ApplicationPath;
                    appPath = appPath.Replace('\\', '/').Trim();
                    if (!appPath.EndsWith("/"))
                        appPath += "/";
                }
            }
            return appPath;
        } 
        /// <summary>
        /// 获取相对应用根目录的应用程序路径
        /// </summary>
        /// <returns></returns>
        public static string AppStrPath()
        {
            return HttpContext.Current.Request.PhysicalApplicationPath;
        }
    }
}
