using EasyFast.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyFast.Web.Areas.Admin.Controllers.Config
{
    public class UserTypeController : EasyFastControllerBase
    {
        // GET: Admin/UserType
        public ActionResult Index()
        {
            return View();
        }
    }
}