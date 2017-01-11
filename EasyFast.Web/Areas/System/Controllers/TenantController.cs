using EasyFast.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyFast.Web.Areas.System.Controllers
{
    public class TenantController : EasyFastControllerBase
    {
        #region MyRegion

        #endregion
        // GET: System/Tenant
        public ActionResult Index()
        {
            return View();
        }
    }
}