using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Collections;
using System.Data;

namespace GY.Core.Utils.Serializer.SerializerConverter
{
    /// <summary>
    /// 转化为Json的DataSet转化器
    /// </summary>
    public class DataSetJavaScriptConverter : JavaScriptConverter
    {
        public override IEnumerable<Type> SupportedTypes
        {
            get { return new Type[] { typeof(DataSet) }; }
        }

        public override object Deserialize(IDictionary<string, object> dictionary, Type type,
                                           JavaScriptSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            DataSet dataSet = obj as DataSet;
            Dictionary<string, object> tables = new Dictionary<string, object>();

            if (dataSet != null)
            {
                foreach (DataTable dt in dataSet.Tables)
                {
                    tables.Add(dt.TableName, dt);
                }
            }

            return tables;
        }
    }
}
