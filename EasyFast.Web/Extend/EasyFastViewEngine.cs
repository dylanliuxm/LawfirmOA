using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyFast.Web.Extend
{
    public class EasyFastViewEngine : RazorViewEngine
    {
        public EasyFastViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
                "~/Views/Areas/{1}/{0}.cshtml"//我们的规则
            };
            AreaViewLocationFormats = new[]
            {
                "~/Areas/{2}/Views/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/Shared/{0}.cshtml",

                "~/Areas/{2}/Views/Config/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/User/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/Case/{1}/{0}.cshtml",

                "~/Areas/{2}/Views/Config/Shared/{0}.cshtml",
                "~/Areas/{2}/Views/User/Shared/{0}.cshtml",
                "~/Areas/{2}/Views/Case/Shared/{0}.cshtml"
            };
        }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            return base.FindView(controllerContext, viewName, masterName, useCache);
        }

        public static void Config()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new EasyFastViewEngine());
        }
    }
}