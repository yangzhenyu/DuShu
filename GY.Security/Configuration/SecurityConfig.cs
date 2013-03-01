using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Configuration;

namespace GY.Security.Configuration
{
    /// <summary>
    ///  权限管理的默认配置类
    /// </summary>
    public class SecurityConfig : ConfigurationSection
    {
        private static SecurityConfig _default = null;

        /// <summary>
        /// 默认实例对象.
        /// </summary>
        public static SecurityConfig Default
        {
            get
            {
                if (_default == null)
                {
                    lock (typeof(SecurityConfig))
                    {
                        if (_default == null)
                            _default = ConfigurationManager.GetSection("gy/security") as SecurityConfig;
                    }
                }
                return _default;
            }
        }

        /// <summary>
        ///  存储userName的cookie的KEY
        /// </summary>
        [ConfigurationProperty("userNameCookieKey", DefaultValue = "aa")]
        public string UserNameCookieKey
        {
            get { return (string)this["userNameCookieKey"]; }
            set { this["userNameCookieKey"] = value; }
        } 

        /// <summary>
        /// 是否大小写敏感,用于用户登录
        /// </summary>
        [ConfigurationProperty("isCaseSensitive", DefaultValue = true)]
        public bool IsCaseSensitive
        {
            get { return (bool)this["isCaseSensitive"]; }
            set { this["isCaseSensitive"] = value; }
        }
          

    }
}
