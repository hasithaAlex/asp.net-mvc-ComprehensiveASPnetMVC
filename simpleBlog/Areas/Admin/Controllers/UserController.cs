﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpleBlog.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return Content("USERS!");
        }
    }
}