using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GY.Security.Model;
using GY.Core.BaseModel;
using DuShu.BLL.Interface;
using GY.Security.Interface;

namespace GY.Security.BLL
{
    public class ResourcesService : IResourcesService
    {
        #region [Dao数据层]
        private IResourcesDao resourcesDao = null;
        public IResourcesDao ResourcesDao
        {
            get { return resourcesDao; }
            set { resourcesDao = value; }
        }
        #endregion [Dao数据层]


        /// <summary>
        ///  新增数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public object Insert(Resources info)
        {
            return ResourcesDao.Insert(info);
        }

        /// <summary>
        ///  根据ID，删除单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Delete(Resources info)
        {
            return ResourcesDao.Delete(info);
        }

        /// <summary>
        ///  根据ID，更新单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Update(Resources info)
        {
            return ResourcesDao.Update(info);
        }

        /// <summary>
        ///  根据ID，获取单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Resources GetById(Resources info)
        {
            return ResourcesDao.GetById(info);
        }

        /// <summary>
        ///  分页获取信息列表
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public IList<Resources> GetList(Paging paging)
        {
            return ResourcesDao.GetList(paging);
        }

        /// <summary>
        ///  按条件获取列表，不分页
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public IList<Resources> GetList(Resources info)
        {
            return ResourcesDao.GetList(info);
        }

        /// <summary>
        ///  获取表中所有数据
        /// </summary> 
        /// <returns></returns>
        public IList<Resources> GetAll()
        {
            return ResourcesDao.GetAll();
        }
    }
}
