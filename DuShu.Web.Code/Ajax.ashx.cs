﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.SessionState;
using DuShu.Web.Code.Handler;

namespace DuShu.Web.Code
{
    /// <summary>
    /// Ajax 的摘要说明
    /// </summary>
    public class Ajax : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                context.Response.ContentType = "text/plain";
                HttpRequest Request = context.Request;
                HttpResponse Response = context.Response;

                //防止数据泄露，以后可以去掉
                if (Request.RequestType.Trim().ToLower() == "get" && Request.QueryString["handler"] != "gloab" && Request.QueryString["handler"] != "checkcode")
                {
                    HandlerResult hresult = new HandlerResult { Result = -1, Message = "不支持GET请求" };
                    Response.Write(hresult.ToString());
                }
                else
                {
                    string handlerName = Request.Params["handler"];

                    if (string.IsNullOrEmpty(handlerName) && string.IsNullOrEmpty(Request.QueryString["handler"]))
                        return;
                    AppHandlerManager.ExecuteHandler(handlerName, HttpContext.Current);
                }
                context.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
                if (ex is ThreadAbortException)
                { }

                //HelloData.FrameWork.Logging.Logger.CurrentLog.Error(ex.Message, ex);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

}
