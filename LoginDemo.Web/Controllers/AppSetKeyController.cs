using LoginDemo.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginDemo.Web.Controllers
{
    public class AppSetKeyController : Controller
    {
        // GET: AppSetting
        public ActionResult Index(string name)
        {


            var model = new AppSettingViewModel();


            /* Instead of httpcontext we can pass parameter into Index method

            //This property available inside every controller
            //Request infomr us anything we want to know about request

                var anme = HttpContext.Request.QueryString["name"]; //One way to access information
            
            //When workign with MVC not recommended to use HttpContext directly. 
            */


            model.Message = ConfigurationManager.AppSettings["message"];

            model.Name = name ?? "No Name Available";
            return View(model);
        }
    }
}