using Abp.Web.Models;
using EasyFast.Application.Edition;
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
        #region MyRegion
        private IEditionAppService _editionAppService;
        public EditionController(IEditionAppService editionAppService)
        {
            _editionAppService = editionAppService;
        }
        #endregion

        // GET: System/Edition
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [DontWrapResult]
        public JsonResult DataList()
        {
            var data = _editionAppService.GetList();
            return Json(data);
        }
    }
}