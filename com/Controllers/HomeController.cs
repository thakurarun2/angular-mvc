﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace com.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("~/Client/indexPage.cshtml");
        }
        //E:\Code\angular-mvc\com\Client\indexPage.cshtml
    }
}