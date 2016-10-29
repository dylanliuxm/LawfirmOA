using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;
using EasyFast.Web.Extend;

namespace EasyFast.Web
{
    public class MvcApplication : AbpWebApplication<EasyFastWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig("log4net.config")
            );
            EasyFastViewEngine.Config();//注册多级目录扩展
            base.Application_Start(sender, e);
        }
    }
}
