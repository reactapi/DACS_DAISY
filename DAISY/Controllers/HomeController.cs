﻿using DAISY.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAISY.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        DaisyContext context = new DaisyContext();

        public ActionResult Index()
        {
            string id = User.Identity.GetUserId();
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(id);
            if(user!= null)
            {
                Session["Name"] = user.Name;
            }
            var listsp = context.tb_SANPHAM.OrderBy(p => p.TENSANPHAM).ToList();
            return View(listsp);

        }

        [CustomAuthorize(Roles = "Admin")]//user 1
        public ActionResult Quanly()
        {
            ViewBag.Message = "Chào mừng bạn đến với Quản lý Website.";

            return View();
        }

        [CustomAuthorize(Roles = "Cửa hàng")]//user 2
        //[Authorize(Roles = "Cửa hàng, Admin")]//user 1,2
        public ActionResult Cuahang()
        {
            ViewBag.Message = "Chào mừng bạn đến với Quản lý Cửa Hàng.";

            return View();
        }
        [CustomAuthorize(Roles = "Khách hàng")]//user 3
        public ActionResult Khachhang()
        {
            ViewBag.Message = "Chào mừng bạn đến với Quản lý giỏ hàng.";

            return View();
        }

    }
}