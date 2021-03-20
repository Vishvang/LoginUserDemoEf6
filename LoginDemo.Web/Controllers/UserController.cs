﻿using LoginDomain.DataModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginDemo.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserData db;

        public UserController(IUserData db)
        {
            this.db = db;
        }

        // GET: User
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}