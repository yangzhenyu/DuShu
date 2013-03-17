using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GY.Security.Model;
using GY.Core.BaseModel;

namespace GY.Security.Interface
{
    public interface IResourcesDao
    {

        /// <summary>
        ///  新增数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        object Insert(Resources info);

        /// <summary>
        ///  根据ID，删除单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        int Delete(Resources info);

        /// <summary>
        ///  根据ID，更新单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        int Update(Resources info);


        /// <summary>
        ///  根据ID，获取单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        Resources GetById(Resources info);

        /// <summary>
        ///  分页获取信息列表
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        IList<Resources> GetList(Paging paging);

        /// <summary>
        ///  按条件获取列表，不分页
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        IList<Resources> GetList(Resources info);

        /// <summary>
        ///  获取表中所有数据
        /// </summary> 
        /// <returns></returns>
        IList<Resources> GetAll();
    }
}
