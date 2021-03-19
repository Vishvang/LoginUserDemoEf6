using LoginDomain.DataModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        IUserData db;

        public HomeController()
        {
            db = new InMemoryUserData();
        }


        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult UserList()
        {
            ViewBag.Message = "Your Users Details.";

            return View();
        }
    }
}