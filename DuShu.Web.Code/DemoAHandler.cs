#region Version Info
/* ========================================================================
* 【本类功能概述】
* 
* 作者：王军 时间：2013/3/6 22:29:26
* 文件名：DemoAHandler
* 版本：V1.0.1
* 联系方式：511522329  
*
* 修改者： 时间： 
* 修改说明：
* ========================================================================
*/
#endregion

using DuShu.Web.Code.Handler;

namespace DuShu.Web.Code
{
    public class DemoAHandler : BaseHandler
    {
        public override IAppHandler CreateInstance()
        {
            return new DemoAHandler();
        }

        public override HandlerResult HandlerRequest()
        {
            switch (Request.Params["type"].ToString())
            {
                case "do":
                    return Do();
            }
            return new HandlerResult().DefaultResult();
        }

        public HandlerResult Do()
        {
            return new HandlerResult().DefaultResult();
        }

        public override string HandlerName
        {
            get { return "demo"; }
        }
    }
}
