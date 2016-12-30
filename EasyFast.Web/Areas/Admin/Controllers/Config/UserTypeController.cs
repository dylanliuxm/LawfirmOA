using EasyFast.Application.UserType;
using EasyFast.Application.UserType.Dto;
using EasyFast.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace EasyFast.Web.Areas.Admin.Controllers.Config
{
    public class UserTypeController : EasyFastControllerBase
    {
        private IUserTypeAppService _userTypeAppService;

        public UserTypeController(IUserTypeAppService userTypeAppService)
        {
            _userTypeAppService = userTypeAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            UserTypeInput model = new UserTypeInput();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(UserTypeInput model)
        {
            if (ModelState.IsValid)
            {
                long l = _userTypeAppService.Add(model);
                if (l > 0)
                {
                    ViewBag.Result = true;
                }
                else
                {
                    ModelState.AddModelError("", "人员类别名称重复！");
                }
            }
            return View();
        }

        public ActionResult Update(long id)
        {
            var model = _userTypeAppService.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(UserTypeInput model)
        {
            if (ModelState.IsValid)
            {
                long l = _userTypeAppService.Update(model);
                if (l > 0)
                {
                    ViewBag.Result = true;
                }
                else
                {
                    ModelState.AddModelError("", "人员类别名称重复！");
                }
            }
            return View(model);
        }

        [HttpPost]
        public JsonResult GetDataGrid(UserTypeSearch model)
        {
            var data = _userTypeAppService.GetDataGrid(model);
            return Json(data);
        }

        [HttpPost]
        public JsonResult CheckIsHaveUser(long[] ids)
        {
            return Json(_userTypeAppService.CheckIsHaveUser(ids));
        }

        public ActionResult Delete(string ids)
        {
            return View();
        }
    }
}