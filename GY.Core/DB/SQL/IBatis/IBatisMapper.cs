using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using IBatisNet;
using IBatisNet.Common;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.MappedStatements;
using IBatisNet.DataMapper.Scope;
using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper.Configuration;
using GY.Core.DB.SQL.IBatis.Interface;
using GY.Core.Delegate;
namespace GY.Core.DB.SQL.IBatis
{
    /// <summary>
    /// 多数据源IBatisNet Mapper 辅助类.
    /// </summary>
    public class IBatisMapper : IIBatisMapper
    {
        /// <summary>
        /// IBatisNet 的 ISqlMapper 实例对象，注入.
        /// </summary>
        public ISqlMapper Mapper
        {
            get;
            set;
        } 

        /// <summary>
        /// 插入指定 statementId、paramValue 的数据.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        public object Insert(string statementId, object paramValue)
        {
            return Mapper.Insert(statementId, paramValue);
        }

        /// <summary>
        /// 更新指定 statementId、paramValue 的数据.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        public int Update(string statementId, object paramValue)
        {
            return Mapper.Update(statementId, paramValue);
        }

        /// <summary>
        /// 删除指定 statementId、paramValue 的数据.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        public int Delete(string statementId, object paramValue)
        {
            return Mapper.Delete(statementId, paramValue);
        }

        /// <summary>
        /// 根据 statementId、paramValue 获取对象T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        public T Load<T>(string statementId, object paramValue)
        {
            IList<T> list = Mapper.QueryForList<T>(statementId, paramValue);
            if (null == list || list.Count == 0)
            {
                return default(T);
            }
            return list[0];
        }

        /// <summary>
        /// 根据 statementId 获取对象 T 列表
        /// </summary>
        /// <returns></returns>
        public IList<T> Select<T>(string statementId)
        {
            return Mapper.QueryForList<T>(statementId, null);
        }

        /// <summary>
        /// 根据statementId、paramValue获取对象T列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        public IList<T> Select<T>(string statementId, object paramValue)
        {
            return Mapper.QueryForList<T>(statementId, paramValue);
        }

        /// <summary>
        /// 根据statementId、paramValue获取对象数据集.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        public DataSet SelectDataSet(string statementId, object paramValue)
        {
            DataSet result = new DataSet();

            IMappedStatement statement = Mapper.GetMappedStatement(statementId);
            if (!Mapper.IsSessionStarted)
            {
                Mapper.OpenConnection();
            }
            RequestScope scope = statement.Statement.Sql.GetRequestScope(statement, paramValue, Mapper.LocalSession);
            statement.PreparedCommand.Create(scope, Mapper.LocalSession, statement.Statement, paramValue);

            IDbCommand command = Mapper.LocalSession.CreateCommand(CommandType.Text);
            command.CommandText = scope.IDbCommand.CommandText;
            foreach (IDataParameter parameter in scope.IDbCommand.Parameters)
            {
                IDbDataParameter item = Mapper.LocalSession.CreateDataParameter();
                item.ParameterName = parameter.ParameterName;
                item.Value = parameter.Value;
                command.Parameters.Add(item);
            }
            Mapper.LocalSession.CreateDataAdapter(command).Fill(result);
            return result;
        }

        /// <summary>
        /// 根据statementId、paramValue获取 SQL 字符串.
        /// </summary>
        /// <param name="statementId"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        public string GetSql(string statementId, object paramValue)
        {
            IMappedStatement statement = Mapper.GetMappedStatement(statementId);
            if (!Mapper.IsSessionStarted)
            {
                Mapper.OpenConnection();
            }
            RequestScope scope = statement.Statement.Sql.GetRequestScope(statement, paramValue, Mapper.LocalSession);

            return scope.PreparedStatement.PreparedSql;
        }

        /// <summary>
        /// 批量提交.
        /// </summary>
        /// <param name="d"></param>
        public void Commit(ArgumentsDelegate.NoneArgumentsDelegate d)
        {
            Commit(d, null);
        }

        /// <summary>
        /// 批量提交，可自定义抛出的异常信息.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="errorMessage"></param>
        public void Commit(ArgumentsDelegate.NoneArgumentsDelegate d, string errorMessage)
        {
            try
            {
                Mapper.BeginTransaction();
                d();
                Mapper.CommitTransaction();
            }
            catch (IBatisNet.DataMapper.Exceptions.DataMapperException ex)
            {
                Mapper.RollBackTransaction();
                if (null == errorMessage)
                {
                    throw ex;
                }
                else
                {
                    throw new ApplicationException(errorMessage, ex);
                }
            }
        }
        /// <summary>
        /// 开始事务
        /// </summary>
        /// <param name="d"></param>
        /// <param name="errorMessage"></param>
        public void BeginTransaction()
        {
            Mapper.BeginTransaction();
        }
        /// <summary>
        /// 提交事务
        /// </summary>
        /// <param name="d"></param>
        /// <param name="errorMessage"></param>
        public void CommitTransaction()
        {
            Mapper.CommitTransaction();
        } 

        /// <summary>
        /// RollBack事务
        /// </summary>
        /// <param name="d"></param>
        /// <param name="errorMessage"></param>
        public void RollBackTransaction()
        {
            Mapper.RollBackTransaction();
        }
 
    }
}
