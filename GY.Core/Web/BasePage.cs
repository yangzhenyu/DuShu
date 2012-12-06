using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using GY.Core.Configuration;

namespace GY.Core.Web
{  
    /// <summary>
    ///  页面基础类.
    /// </summary>
    public class BasePage :Page
    {
        
        /// <summary>
        /// 系统提示信息
        /// </summary>
        public static string CurrentMessage
        {
            get
            {
                try
                {
                    object message = System.Web.HttpContext.Current.Session[GlobalConfig.Instance.MessageKey];
                    return (null == message) ? String.Empty : message.ToString();
                }
                catch (Exception ex)
                { 
                    return ex.Message; 
                }
            }
            set
            {
                try
                {
                    System.Web.HttpContext.Current.Session[GlobalConfig.Instance.MessageKey] = value;
                }
                catch { }
            }
        } 


    }
}
