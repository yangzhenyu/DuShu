using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using GY.Security.Model;
using GY.Core.BaseModel;

namespace GY.Security.DAO.Interface
{
   public interface IUsersDao
    { 

        /// <summary>
        ///  新增数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
       object Insert(Users info);

        /// <summary>
        ///  根据ID，删除单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
       int Delete(Users info);

        /// <summary>
        ///  根据ID，更新单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
       int Update(Users info);


        /// <summary>
        ///  根据ID，获取单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
       Users GetById(Users info);

        /// <summary>
        ///  分页获取信息列表
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
       IList<Users> GetList(Paging paging);

    }
}
