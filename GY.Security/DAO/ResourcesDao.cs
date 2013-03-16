using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GY.Security.Interface;
using GY.Core.DB.SQL.IBatis.Interface;
using GY.Security.Model;
using GY.Core.BaseModel;

namespace GY.Security
{
    public class ResourcesDao : IResourcesDao
    {
        #region [动态配置数据接口]
        private IIBatisMapper iBatisMapper = null;
        public IIBatisMapper IBatisMapper
        {
            get { return iBatisMapper; }
            set { iBatisMapper = value; }
        }
        #endregion [动态配置数据接口]


        /// <summary>
        ///  新增数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public object Insert(Resources info)
        {
            return IBatisMapper.Insert("InsertResources", info);
        }

        /// <summary>
        ///  根据ID，删除单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Delete(Resources info)
        {
            return IBatisMapper.Delete("DeleteResources", info);
        }

        /// <summary>
        ///  根据ID，更新单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Update(Resources info)
        {
            return IBatisMapper.Update("UpdateResources", info);
        }


        /// <summary>
        ///  根据ID，获取单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Resources GetById(Resources info)
        {
            return IBatisMapper.Load<Resources>("GetResourcesById", info);
        }

        /// <summary>
        ///  分页获取信息列表
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public IList<Resources> GetList(Paging paging)
        {
            return IBatisMapper.Select<Resources>("GetResourcesPagingList", paging);
        }

        /// <summary>
        ///  按条件获取列表，不分页
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public IList<Resources> GetList(Resources info)
        {
            return IBatisMapper.Select<Resources>("GetResourcesInfo", info);
        }

        /// <summary>
        ///  获取表中所有数据
        /// </summary> 
        /// <returns></returns>
        public IList<Resources> GetAll()
        {
            return IBatisMapper.Select<Resources>("GetResourcesAll");
        }
    }
}
