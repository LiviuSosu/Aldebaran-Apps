using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobotAPIs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new Models.RobotEntities();
            //db.Commands.Add(new Models.Command { CommandName= "Avicii dance", CommandDescription = "The robot will dance avicii - wkae me up"});
            //db.Commands.Add(new Models.Command { CommandName = "Stop", CommandDescription = "Stops the application" });
            //db.SaveChanges();
            return View();
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
    }
}