using EasyFast.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyFast.Web.Areas.System.Controllers
{
    public class EditionController : EasyFastControllerBase
    {
        // GET: System/Edition
        public ActionResult Index()
        {
            return View();
        }
    }
}