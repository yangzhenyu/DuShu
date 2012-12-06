using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.Core.BaseModel
{
     /// <summary>
     /// 分页面的基础模型
     /// </summary> 
    [Serializable]
    public class Paging
    {
        public Paging()
        {
            FieldShow = "*";
            FieldOrder = "";
            Where = "";
        }
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 主键列名
        /// </summary>
        public string FieldKey { get; set; }
        /// <summary>
        /// 选择当前页
        /// </summary>
        public int PageCurrent { get; set; }
        /// <summary>
        /// 分页条数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 显示的列名
        /// </summary>
        public string FieldShow { get; set; }
        /// <summary>
        /// 排序的列名
        /// </summary>
        public string FieldOrder { get; set; }
        /// <summary>
        /// 查询的条件
        /// </summary>
        public string Where { get; set; }
        /// <summary>
        /// 查询后返回的总条件数
        /// </summary>
        public int RecordCount { get; set; }
    }
}
