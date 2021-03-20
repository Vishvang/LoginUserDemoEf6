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

            /*
            if (string.IsNullOrEmpty(user_Cl.Username))
            {
                ModelState.AddModelError(nameof(user_Cl.Username), "The username is required");
            }*/

            if (ModelState.IsValid)
            {
                db.Add(user_Cl);


                //Why we should redirect to some other get request page as after any post if user refresh , second post req will be generate.
                //return View("Details");
                return RedirectToAction("Details", new { id=user_Cl.UserID});
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            var model = db.Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(User_cl user)
        {
            if (ModelState.IsValid)
            {
                db.Update(user);

                return RedirectToAction("Details", new { id = user.UserID });
            }
            return View(user);
        }
    }
}