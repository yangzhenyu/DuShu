using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.Core.BaseModel
{    
    /// <summary>
    /// Label模型，包含ID与Label,继承于ID类
    /// </summary>
    [Serializable]
   public class Label:ID
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        public string Name { get; set; }
    }
}
