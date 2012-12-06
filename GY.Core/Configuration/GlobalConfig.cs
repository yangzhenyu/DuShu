using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace GY.Core.Configuration
{
    public class GlobalConfig : ConfigurationSection
    {
        private static GlobalConfig instance = null;

        /// <summary>
        /// 实例对象.
        /// </summary>
        public static GlobalConfig Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(GlobalConfig))
                    {
                        if (instance == null)
                        {
                            instance = ConfigurationManager.GetSection("gy/global") as GlobalConfig;
                            if (null == instance)
                            {
                                instance = new GlobalConfig();
                            }
                        }
                    }
                }
                return instance;
            }
        }

        #region [所有参数]
         /// <summary>
        /// 文件上传临时目录.
        /// </summary>
        [ConfigurationProperty("messageKey", DefaultValue = "{}")]
        public string MessageKey
        {
            get { return (string)this["messageKey"]; }
            set { this["messageKey"] = value; }
        }
        /// <summary>
        /// 文件上传临时目录.
        /// </summary>
        [ConfigurationProperty("uploadPath", DefaultValue = "UploadPath/Temp/")]
        public string UploadPath
        {
            get { return (string)this["uploadPath"]; }
            set { this["uploadPath"] = value; }
        }

        /// <summary>
        /// 操作成功的提示信息.
        /// </summary>
        [ConfigurationProperty("successMessage", DefaultValue = "操作成功.")]
        public string SuccessMessage
        {
            get { return (string)this["successMessage"]; }
            set { this["successMessage"] = value; }
        }

        /// <summary>
        /// 操作失败的提示信息.
        /// </summary>
        [ConfigurationProperty("failMessage", DefaultValue = "操作失败.")]
        public string FailMessage
        {
            get { return (string)this["failMessage"]; }
            set { this["failMessage"] = value; }
        }

        /// <summary>
        /// 没有对应权限的提示信息.
        /// </summary>
        [ConfigurationProperty("noPermissionMessage", DefaultValue = "权限不足够，请联系管理员.")]
        public string NoPermissionMessage
        {
            get { return (string)this["noPermissionMessage"]; }
            set { this["noPermissionMessage"] = value; }
        } 

        /// <summary>
        /// 格式化异常提示信息.
        /// </summary>
        [ConfigurationProperty("formatExceptionMessage", DefaultValue = "格式异常.")]
        public string FormatExceptionMessage
        {
            get { return (string)this["formatExceptionMessage"]; }
            set { this["formatExceptionMessage"] = value; }
        }

        /// <summary>
        /// 参数异常提示信息.
        /// </summary>
        [ConfigurationProperty("argumentExceptionMessage", DefaultValue = "参数错误.")]
        public string ArgumentExceptionMessage
        {
            get { return (string)this["argumentExceptionMessage"]; }
            set { this["argumentExceptionMessage"] = value; }
        }

        /// <summary>
        /// 删除操作前的确认信息.
        /// </summary>
        [ConfigurationProperty("confirmDeleteMessage", DefaultValue = "确定删除?")]
        public string ConfirmBeforeDeleteMessage
        {
            get { return (string)this["confirmDeleteMessage"]; }
            set { this["confirmDeleteMessage"] = value; }
        }

        /// <summary>
        /// 系统访问址.
        /// </summary>
        [ConfigurationProperty("address",DefaultValue = "yangzhenyu2008@126.com")]
        public string Address
        {
            get { return (string)this["address"]; }
            set { this["address"] = value; }
        }

        /// <summary>
        /// 系统签名，该系统的内容叫什么
        /// </summary>
        [ConfigurationProperty("signature", DefaultValue = "读书网.")]
        public string Signature
        {
            get { return (string)this["signature"]; }
            set { this["signature"] = value; }
        }
        #endregion [所有参数]

    }
}
