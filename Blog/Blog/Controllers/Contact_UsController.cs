﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class Contact_UsController : Controller
    {
        // GET: Contact_Us
        public ActionResult Index()
        {
            return View();
        }
    }
}