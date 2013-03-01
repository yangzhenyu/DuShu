using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper.Configuration;
using System.Configuration; 
using System.Collections;

namespace GY.Core.DB.SQL.IBatis
{
    /// <summary>
    /// 自定义数据源
    /// </summary>
    public class CustomSqlMapper
    { 
        /// <summary>
        /// Mapper的Hashtable对象
        /// </summary>
        private static Hashtable mapperHolder = Hashtable.Synchronized(new Hashtable()); 
        /// <summary>
        /// 日志记录
        /// </summary>
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(CustomSqlMapper)); 
        /// <summary>
        /// 初始化SQLMqpper对象
        /// </summary>
        /// <param name="configFile"></param>
        /// <returns></returns>
        protected static ISqlMapper InitMapper(string configFile)
        {
            ConfigureHandler handler = new ConfigureHandler((obj) => { log.Info(obj); });
            DomSqlMapBuilder builder = new DomSqlMapBuilder(); 
            return builder.ConfigureAndWatch(configFile, handler); 
        } 
        /// <summary>
        /// 获取SQLMapper对象
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static ISqlMapper Get(string config = DomSqlMapBuilder.DEFAULT_FILE_CONFIG_NAME)
        {
            ISqlMapper sqlMap = null;
            object mapper = mapperHolder[config];
            if (mapper == null)
            {
                sqlMap = InitMapper(config);
                if (sqlMap != null)
                {
                    mapperHolder.Add(config, sqlMap);
                } 
            }
            else
            { 
                sqlMap = mapper as ISqlMapper;
            }
            return sqlMap;

        }
    }
}
