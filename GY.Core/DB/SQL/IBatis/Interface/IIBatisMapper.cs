using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using IBatisNet;
using IBatisNet;
using IBatisNet.Common;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.MappedStatements;
using IBatisNet.DataMapper.Scope;
using GY.Core.Delegate;
namespace GY.Core.DB.SQL.IBatis.Interface
{
    /// <summary>
    /// 多数据源MyBatisNet Mapper 的接口.
    /// </summary>
    public interface IIBatisMapper 
    {
          
        /// <summary>
        /// 插入指定 statementId、paramValue 的数据.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        object Insert(string statementId, object paramValue);

        /// <summary>
        /// 更新指定 statementId、paramValue 的数据.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        int Update(string statementId, object paramValue);

        /// <summary>
        /// 删除指定 statementId、paramValue 的数据.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        int Delete(string statementId, object paramValue);

        /// <summary>
        /// 根据 statementId、paramValue 获取对象T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        T Load<T>(string statementId, object paramValue);

        /// <summary>
        /// 根据 statementId 获取对象 T 列表
        /// </summary>
        /// <returns></returns>
        IList<T> Select<T>(string statementId);

        /// <summary>
        /// 根据statementId、paramValue获取对象T列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        IList<T> Select<T>(string statementId, object paramValue);

        /// <summary>
        /// 根据statementId、paramValue获取对象数据集.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        DataSet SelectDataSet(string statementId, object paramValue);

        /// <summary>
        /// 根据statementId、paramValue获取 SQL 字符串.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        string GetSql(string statementId, object paramValue);

        /// <summary>
        /// 批量提交.
        /// </summary>
        /// <param name="d"></param>
        void Commit(ArgumentsDelegate.NoneArgumentsDelegate d);

        /// <summary>
        /// 批量提交，可自定义抛出的异常信息.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="errorMessage"></param>
        void Commit(ArgumentsDelegate.NoneArgumentsDelegate d, string errorMessage);

        /// <summary>
        /// 开始事务
        /// </summary>
        /// <param name="d"></param>
        /// <param name="errorMessage"></param>
        void BeginTransaction();

        /// <summary>
        /// 提交事务
        /// </summary>
        /// <param name="d"></param>
        /// <param name="errorMessage"></param>
        void CommitTransaction();

        /// <summary>
        /// RollBack事务
        /// </summary>
        /// <param name="d"></param>
        /// <param name="errorMessage"></param>
        void RollBackTransaction();
  

    }
}
