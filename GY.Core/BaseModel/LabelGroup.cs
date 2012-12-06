using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.Core.BaseModel
{
    /// <summary>
    /// 分组模型
    /// </summary>
    [Serializable]
    public class LabelGroup<C, L>
    {  
        public C Category { get; set; }
        public IList<L> Properties { get; set; }
    }
}
