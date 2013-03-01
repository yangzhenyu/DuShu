using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GY.Security.Model;
using GY.Core.BaseModel; 
using GY.Security.BLL.Interface;
using GY.Security.DAO.Interface;

namespace GY.Security.BLL
{
    public class UsersService : IUsersService
    { 
        #region [Dao数据层]
        private IUsersDao usersDao = null;
        public IUsersDao UsersDao
        {
            get { return usersDao; }
            set { usersDao = value; }
        }
        #endregion [Dao数据层] 


        /// <summary>
        ///  新增数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public object Insert(Users info)
        {
            return UsersDao.Insert(info);
        }

        /// <summary>
        ///  根据ID，删除单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Delete(Users info)
        {
            return UsersDao.Delete(info);
        }

        /// <summary>
        ///  根据ID，更新单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Update(Users info)
        {
            return UsersDao.Update(info);
        }


        /// <summary>
        ///  根据ID，获取单个实例
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Users GetById(Users info)
        {
            return UsersDao.GetById(info);
        }

        /// <summary>
        ///  分页获取信息列表
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public IList<Users> GetList(Paging paging)
        {
            return UsersDao.GetList(paging);
        }


    }
}
