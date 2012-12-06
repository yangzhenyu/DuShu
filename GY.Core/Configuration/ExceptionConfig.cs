using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace GY.Core.Configuration
{
    /// <summary>
    /// 异常记录的整体的配置
    /// </summary>
    public class ExceptionConfig : ConfigurationSection
    {
        private static ExceptionConfig defaultConfig = null;

        /// <summary>
        /// 默认实例对象.
        /// </summary>
        public static ExceptionConfig DefaultConfig
        {
            get
            {
                if (defaultConfig == null)
                {
                    lock (typeof(ExceptionConfig))
                    {
                        if (defaultConfig == null)
                            defaultConfig = ConfigurationManager.GetSection("gy/exception") as ExceptionConfig;
                    }
                }
                return defaultConfig;
            }
        }
        /// <summary>
        /// 是否启用异常捕捉功能.
        /// </summary>
        [ConfigurationProperty("catchException", DefaultValue = true)]
        public bool CatchException
        {
            get { return (bool)this["catchException"]; }
            set { this["catchException"] = value; }
        }

        /// <summary>
        /// 接受异常报告的Email.
        /// </summary>
        [ConfigurationProperty("receiveMail", DefaultValue = "")]
        public string ReceiveMail
        {
            get { return (string)this["receiveMail"]; }
            set { this["receiveMail"] = value; }
        }

        /// <summary>
        /// 发生DataException类型的异常时，提示给用户的消息.
        /// </summary>
        [ConfigurationProperty("dataException", DefaultValue = "数据处理错误")]
        public string DataException
        {
            get { return (string)this["dataException"]; }
            set { this["dataException"] = value; }
        }

        /// <summary>
        /// 发生HttpException类型的异常时，提示给用户的消息.
        /// </summary>
        [ConfigurationProperty("httpException", DefaultValue = "页面请求失败")]
        public string HttpException
        {
            get { return (string)this["httpException"]; }
            set { this["httpException"] = value; }
        }

        /// <summary>
        ///  发生HttpUnhandledException类型的异常时，提示给用户的消息.
        /// </summary>
        [ConfigurationProperty("httpUnhandledException", DefaultValue = "应用程序常规错误")]
        public string HttpUnhandledException
        {
            get { return (string)this["httpUnhandledException"]; }
            set { this["httpUnhandledException"] = value; }
        }

        /// <summary>
        ///  发生SqlException类型的异常时，提示给用户的消息.
        /// </summary>
        [ConfigurationProperty("sqlException", DefaultValue = "数据库操作失败")]
        public string SqlException
        {
            get { return (string)this["sqlException"]; }
            set { this["sqlException"] = value; }
        }

        /// <summary>
        ///  发生未被定义类型的异常时，提示给用户的消息.
        /// </summary>
        [ConfigurationProperty("otherException", DefaultValue = "OtherException")]
        public string OtherException
        {
            get { return (string)this["otherException"]; }
            set { this["otherException"] = value; }
        }


    }
}
