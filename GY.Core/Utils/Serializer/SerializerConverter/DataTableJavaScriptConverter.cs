using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Collections;
using System.Data;


namespace GY.Core.Utils.Serializer.SerializerConverter
{
    /// <summary>
    /// 转化为Json的DataTable转化器
    /// </summary>
    public class DataTableJavaScriptConverter : JavaScriptConverter
    {
        public override IEnumerable<Type> SupportedTypes
        {
            get { return new Type[] { typeof(DataTable) }; }
        }

        public override object Deserialize(IDictionary<string, object> dictionary, Type type,
                                           JavaScriptSerializer serializer)
        {
            throw new NotImplementedException();
        }


        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            DataTable table = obj as DataTable;
            // *** result 'object'
            Dictionary<string, object> result = new Dictionary<string, object>();

            if (table != null)
            {
                // *** We'll represent rows as an array/listType
                List<object> rows = new List<object>();

                foreach (DataRow row in table.Rows)
                {
                    rows.Add(row);  // Rely on DataRowConverter to handle
                }
                result["Rows"] = rows;

                return result;
            }

            return new Dictionary<string, object>();
        }
    }
}
