using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.Core.Utils.Threading
{
    /// <summary>
    /// 同步调用服务接口.
    /// </summary>
    public interface ISyncCaller
    {

        /// <summary>
        /// 执行调用.
        /// </summary>
        void Call();
    }
}
