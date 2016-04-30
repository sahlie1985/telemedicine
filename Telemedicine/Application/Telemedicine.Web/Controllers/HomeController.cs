﻿using System.Web.Mvc;
using Telemedicine.Web.Attributes;

namespace Telemedicine.Web.Controllers
{
    [AuthorizeUser()]
    public class HomeController : Controller
    {       
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}