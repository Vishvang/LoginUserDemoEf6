using LoginDomain.Classes;
using LoginDomain.DataModel.Services;
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
        
        public ActionResult Details(Guid id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                //return RedirectToAction("Index");
                return View("NotFound");    //Look for this view
            }
            return View(model);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(User_cl user_Cl)
        {

            /*We can access individual html here to check is value and error.
            var err = ModelState["Username"].Errors;
            var value = ModelState["Username"].Value;
            */


            if (string.IsNullOrEmpty(user_Cl.Username))
            {
                ModelState.AddModelError(nameof(user_Cl.Username), "The username is required");
            }

            if (ModelState.IsValid)
            {
                db.Add(user_Cl);
                return View("Details");
            }
            return View();
        }

        
    }
}