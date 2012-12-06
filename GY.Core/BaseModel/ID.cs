using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.Core.BaseModel
{
    /// <summary>
    /// ID模型，只有ID的列
    /// </summary>
    [Serializable]
    public class ID
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Key { get; set; }
    }
}
