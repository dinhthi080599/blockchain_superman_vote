﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpchainWebAPI.Models;

namespace CSharpchainWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
