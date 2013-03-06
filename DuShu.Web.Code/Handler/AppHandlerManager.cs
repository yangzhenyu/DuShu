#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/3/6 00:06:07
* 文件名：AppHandlerManager
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
using System.Web;

namespace DuShu.Web.Code.Handler
{
    public class AppHandlerManager
    {
        private static Dictionary<string, IAppHandler> s_Handlers = new Dictionary<string, IAppHandler>(StringComparer.OrdinalIgnoreCase);

        public static void RegisterAppHandler(IAppHandler handler)
        {
            if (s_Handlers.ContainsKey(handler.HandlerName))
                s_Handlers[handler.HandlerName] = handler;
            else
                s_Handlers.Add(handler.HandlerName, handler);
        }

        public static void ExecuteHandler(string name, HttpContext context)
        {
            IAppHandler handler;

            if (s_Handlers.TryGetValue(name, out handler))
                context.Response.Write(handler.CreateInstance().ProcessRequest(context).ToString());
        }
    }
}
