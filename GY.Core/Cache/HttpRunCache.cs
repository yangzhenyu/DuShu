using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace GY.Core.Cache
{
  public class HttpRunCache
    {
         /// <summary>
         /// 缓存的委托
         /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public delegate IList<T> CacheHandler<T>();
        /// <summary>
        ///  获取缓存的值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cacheKey"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IList<T> GetCacheData<T>(string cacheKey, CacheHandler<T> data)
        {
            IList<T> cacheList = null;
            if (HttpRuntime.Cache[cacheKey] == null)
            {
                cacheList = data();
                HttpRuntime.Cache.Insert(cacheKey, cacheList, null, DateTime.MaxValue, TimeSpan.Zero);
            }
            else
            {
                cacheList = (IList<T>)HttpRuntime.Cache[cacheKey];
            }
            return cacheList;
        }
    }
}
