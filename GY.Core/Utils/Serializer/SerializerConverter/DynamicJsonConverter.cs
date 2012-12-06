using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Collections;
using System.Data;
using System.Collections.ObjectModel;

namespace GY.Core.Utils.Serializer.SerializerConverter
{
    /// <summary>
    /// 转化为Json的DataRow转化器
    /// </summary>
    public class DynamicJsonConverter : JavaScriptConverter
    {
        public override IEnumerable<Type> SupportedTypes
        {
            get { return new ReadOnlyCollection<Type>(new List<Type>(new Type[] { typeof(object) })); }
        }

        public override object Deserialize(IDictionary<string, object> dictionary, Type type,
                                           JavaScriptSerializer serializer)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException("dictionary");
            }
            if (type == typeof(object))
            {

                return new DynamicJsonObject(dictionary);
            }

            return null;
        }

        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
