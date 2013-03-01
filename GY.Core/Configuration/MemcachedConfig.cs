using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace GY.Core.Configuration
{
    /// <summary>
    ///  Memcached的服务配置
    /// </summary>
    public class MemcachedConfig : ConfigurationSection
    { 
       private static MemcachedConfig _default = null;

       /// <summary>
       /// 默认实例对象.
       /// </summary>
       public static MemcachedConfig Default
       {
           get
           {
               if (_default == null)
               {
                   lock (typeof(MemcachedConfig))
                   {
                       if (_default == null)
                           _default = ConfigurationManager.GetSection("gy/memcached") as MemcachedConfig;
                   }
               }
               return _default;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       [ConfigurationProperty("serverList", DefaultValue = "")]
       public string ServerList
       {
           get { return (string)this["serverList"]; }
           set { this["serverList"] = value; }
       }

       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("initConnections", DefaultValue = "3")]
       public int InitConnections
       {
           get { return (int)this["initConnections"]; }
           set { this["initConnections"] = value; }
       } 
      
       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("minConnections", DefaultValue = "3")]
       public int MinConnections
       {
           get { return (int)this["minConnections"]; }
           set { this["minConnections"] = value; }
       }
      
       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("maxConnections", DefaultValue = "5")]
       public int MaxConnections
       {
           get { return (int)this["maxConnections"]; }
           set { this["maxConnections"] = value; }
       }
       
       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("socketConnectTimeout", DefaultValue ="1000")]
       public int SocketConnectTimeout
       {
           get { return (int)this["socketConnectTimeout"]; }
           set { this["socketConnectTimeout"] = value; }
       }
      
       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("socketTimeout", DefaultValue ="3000")]
       public int SocketTimeout
       {
           get { return (int)this["socketTimeout"]; }
           set { this["socketTimeout"] = value; }
       }
       
       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("maintenanceSleep", DefaultValue ="30")]
       public int MaintenanceSleep
       {
           get { return (int)this["maintenanceSleep"]; }
           set { this["maintenanceSleep"] = value; }
       }
       
       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("failover", DefaultValue =true)]
       public bool Failover
       {
           get { return (bool)this["failover"]; }
           set { this["failover"] = value; }
       }   
       
       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("nagle", DefaultValue =false)]
       public bool Nagle
       {
           get { return (bool)this["nagle"]; }
           set { this["nagle"] = value; }
       }  
       
       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("enableCompression", DefaultValue =true)]
       public bool EnableCompression
       {
           get { return (bool)this["enableCompression"]; }
           set { this["enableCompression"] = value; }
       }

      
       /// <summary>
       ///  过期时间点，格式28800000 毫秒 即1000*60*60*8 表示每天 早上8点过期  
       /// </summary>
       [ConfigurationProperty("expired", DefaultValue = "28800000")]
       public long Expired
       {
           get { return (long)this["expired"]; }
           set { this["expired"] = value; }
       }

       /// <summary>
       ///  
       /// </summary>
       [ConfigurationProperty("cacheTimeout", DefaultValue ="")]
       public DateTime CacheTimeout
       {
           get 
           {
               try
               {
                   DateTime expiredTime = DateTime.Today.AddMilliseconds(this.Expired); 
                   return expiredTime > DateTime.Now ? expiredTime : expiredTime.AddDays(1); 
               }
               catch {
                   return DateTime.Now;
               }
           }
       } 
   }
}
