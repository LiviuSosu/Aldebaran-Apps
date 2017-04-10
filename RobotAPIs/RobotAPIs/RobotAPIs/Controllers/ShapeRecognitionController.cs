using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobotAPIs.Controllers
{
    public class ShapeRecognitionController : Controller
    {
        // GET: ShapeRecognition
        public ActionResult Index()
        {
            //http://www.aforgenet.com/framework/
            return View();
        }
    }
}