using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GY.Security.DAO.Interface;
using GY.Core.DB.SQL.IBatis.Interface;
using GY.Security.Model;
using GY.Core.BaseModel;

namespace GY.Security.DAO
{
   public class UsersDao : IUsersDao
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
       public object Insert(Users info)
       {
           return IBatisMapper.Insert("Insert", info);
       } 

       /// <summary>
       ///  根据ID，删除单个实例
       /// </summary>
       /// <param name="info"></param>
       /// <returns></returns>
       public int Delete(Users info)
       {
           return IBatisMapper.Delete("Delete", info);
       } 
        
       /// <summary>
       ///  根据ID，更新单个实例
       /// </summary>
       /// <param name="info"></param>
       /// <returns></returns>
       public int Update(Users info)
       {
           return IBatisMapper.Update("Update", info);
       }


       /// <summary>
       ///  根据ID，获取单个实例
       /// </summary>
       /// <param name="info"></param>
       /// <returns></returns>
       public Users GetById(Users info)
       {
           return IBatisMapper.Load<Users>("GetById", info);
       }
        
       /// <summary>
       ///  分页获取信息列表
       /// </summary>
       /// <param name="paging"></param>
       /// <returns></returns>
       public IList<Users> GetList(Paging paging)
       {
           return IBatisMapper.Select<Users>("GetAll", paging);
       }

    }
}
