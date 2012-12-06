using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Web;
using System.Web.Script.Serialization;
using System.Data;
using GY.Core.Utils.Serializer.SerializerConverter; 

namespace GY.Core.Utils.Serializer
{
    public static class SerializerUtils
    {
        /// <summary>
        /// Json序列化与反序列的方法
        /// </summary>
        private static JavaScriptSerializer  javaScriptSerializer = null;

        /// <summary>
        /// Json序列化的内容
        /// </summary>
        /// <returns></returns>
        private static JavaScriptSerializer GetJavaScriptSerializer()
        { 
            if (javaScriptSerializer == null)
            {
                javaScriptSerializer = new JavaScriptSerializer();
                javaScriptSerializer.RegisterConverters(new List<JavaScriptConverter>() { new DateTimeJavaScriptConverter() });
                javaScriptSerializer.MaxJsonLength = int.MaxValue;
            }
            return javaScriptSerializer;
        }

        /// <summary>
        ///  序列对象为json格式
        /// </summary>
        /// <returns></returns>
        public static string Serialize<T>(T t)
        {
            return GetJavaScriptSerializer().Serialize(t);
        }

        /// <summary>
        ///  从string反序化成泛型对象
        /// </summary>
        /// <returns></returns>
        public static T Deserialize<T>(string Json)
        {
            return GetJavaScriptSerializer().Deserialize<T>(Json);
        }

        /// <summary>
        ///  从string反序化成一个object对象
        /// </summary>
        /// <returns></returns>
        public static object DeserializeObject(string Json)
        {
            return GetJavaScriptSerializer().DeserializeObject(Json);
        }

        /// <summary>
        ///  从object转换为泛型对象
        /// </summary>
        /// <returns></returns>
        public static T ConvertToType<T>(object obj)
        {
            return GetJavaScriptSerializer().ConvertToType<T>(obj);
        }



    }
       

}
