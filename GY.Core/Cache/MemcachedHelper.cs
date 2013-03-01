using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memcached.ClientLibrary;
using System.Collections;
using GY.Core.Configuration;
using log4net;

namespace GY.Core.Cache
{
    /// <summary>
    /// 对Memcached的操作封装
    /// </summary>
    public  class MemcachedHelper
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MemcachedHelper));
        private static MemcachedClient mc = null;
        
        /// <summary>
        /// 当返回为 null时则不采用Memcached，包含未配置Memcached的服务端，或初始化失败都返回null；
        /// </summary>
        /// <returns></returns>
        private static MemcachedClient GetMemcachedClient()
        { 
            if(mc == null)
            {
                //将配置的内容左右去空，并兼容可能由于部署配置引起的问题，即多加了个,
                string serverString = MemcachedConfig.Default.ServerList.Trim().Trim(',');
                if (string.IsNullOrEmpty(serverString))
                {
                    mc = null;
                    log.Info(string.Format("Memcached Server is Null")); 
                }
                else
                {
                    try
                    {
                        log.Info(string.Format("Memcached Setting is Begin"));
                        string[] serverlist = serverString.Split(',');
                        SockIOPool pool = SockIOPool.GetInstance();
                        pool.SetServers(serverlist);
                        pool.InitConnections = MemcachedConfig.Default.InitConnections;
                        pool.MinConnections = MemcachedConfig.Default.MinConnections;
                        pool.MaxConnections = MemcachedConfig.Default.MaxConnections;
                        pool.SocketConnectTimeout = MemcachedConfig.Default.SocketConnectTimeout;
                        pool.SocketTimeout = MemcachedConfig.Default.SocketTimeout;
                        pool.MaintenanceSleep = MemcachedConfig.Default.MaintenanceSleep;
                        pool.Failover = MemcachedConfig.Default.Failover;
                        pool.Nagle = MemcachedConfig.Default.Nagle; ;
                        pool.Initialize(); 
                        mc = new MemcachedClient();
                        mc.EnableCompression = MemcachedConfig.Default.EnableCompression; 
                        log.Info(string.Format("Memcached Setting is End"));
                    }
                    catch (Exception ex)
                    {
                        mc = null;
                        log.Error(string.Format("Memcached Fail,Message:{0}", ex.Message));
                    }
                } 
            }
            return mc;
        } 
        
        /// <summary>
        ///  设置缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vaule"></param>
        /// <returns></returns>
        public static bool Set(string key,object vaule)
        {
            MemcachedClient memcached = GetMemcachedClient();
            if (memcached != null)
            {
                try
                {
                    if (!memcached.KeyExists(key))
                    {
                        memcached.Set(key, vaule);
                    }
                    else
                    {
                        memcached.Replace(key, vaule);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Memcached Set Fail,key:{0},Message:{1}", key, ex.Message));
                    return false;
                }
            }
            else return false;
        }

        /// <summary>
        ///  设置缓存，并设置过期时间
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vaule"></param>
        /// <returns></returns>
        public static bool Set(string key, object vaule, DateTime expiry)
        {
            MemcachedClient memcached = GetMemcachedClient();
            if (memcached != null)
            {
                try
                {
                    if (!memcached.KeyExists(key))
                    {
                        memcached.Set(key, vaule,expiry);
                    }
                    else
                    {
                        memcached.Replace(key, vaule,expiry);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Memcached Set Fail,key:{0},Message:{1}", key, ex.Message));
                    return false;
                }
            }
            else return false;
        }

        /// <summary>
        ///  设置缓存，并设置过期时间
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vaule"></param>
        /// <returns></returns>
        public static bool Set(string key, object vaule, DateTime expiry, int hashCode)
        {
            MemcachedClient memcached = GetMemcachedClient();
            if (memcached != null)
            {
                try
                {
                    if (!memcached.KeyExists(key))
                    {
                        memcached.Set(key, vaule, expiry,hashCode);
                    }
                    else
                    {
                        memcached.Replace(key, vaule, expiry,hashCode);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Memcached Set Fail,key:{0},Message:{1}", key, ex.Message));
                    return false;
                }
            }
            else return false;
        } 
         
        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Delete(string key)
        {
            MemcachedClient memcached = GetMemcachedClient();
            if (memcached != null)
            {
                try
                {
                    if (memcached.KeyExists(key))
                    {
                        memcached.Delete(key); 
                        return true;
                    }
                    else
                    {
                        //不存在,不能Delete
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Memcached Delete Fail,key:{0},Message:{1}", key, ex.Message));
                    return false;
                }
            }
            else return false;
        } 
         
        /// <summary>
        ///  获取缓存的内容，返回转换类型后的内容
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(string key)
        {
            MemcachedClient memcached = GetMemcachedClient();
            if (memcached != null)
            {
                try
                {
                    if (memcached.KeyExists(key))
                    {
                        return (T)memcached.Get(key); 
                    }
                    else
                    {   //不存在，返回default(T);
                        return default(T);
                    }
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Memcached Get Fail,key:{0},Message:{1}", key, ex.Message));
                    return default(T);
                }
            }
            else return default(T);
        }
       
        /// <summary>
        /// 获取缓存的内容，返回object
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object Get(string key)
        {
            MemcachedClient memcached = GetMemcachedClient();
            if (memcached != null)
            {
                try
                {
                    if (memcached.KeyExists(key))
                    {
                        return memcached.Get(key);
                    }
                    else
                    {   //不存在，返回default(T);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Memcached Get Fail,key:{0},Message:{1}", key, ex.Message));
                    return null;
                }
            }
            else return null;
        }
    }
}
