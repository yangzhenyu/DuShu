using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Collections;
using System.Data;
namespace GY.Core.Utils.Serializer.SerializerConverter
{
    /// <summary>
    /// 转化为Json的DataRow转化器
    /// </summary>
    public class DataRowJavaScriptConverter : JavaScriptConverter
    {
        public override IEnumerable<Type> SupportedTypes
        {
            get { return new Type[] { typeof(DataRow) }; }
        }

        public override object Deserialize(IDictionary<string, object> dictionary, Type type,
                                           JavaScriptSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            DataRow dataRow = obj as DataRow;
            Dictionary<string, object> propValues = new Dictionary<string, object>();

            if (dataRow != null)
            {
                foreach (DataColumn dc in dataRow.Table.Columns)
                {
                    propValues.Add(dc.ColumnName, dataRow[dc]);
                }
            }

            return propValues;
        }
    }
}
