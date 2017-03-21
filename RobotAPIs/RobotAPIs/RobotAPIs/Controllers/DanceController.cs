using RobotQuiz.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobotAPIs.Controllers
{
    public class DanceController : Controller
    {
        // GET: Dance
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GaganamDance()
        {
            CommandHelper.SetCurrentCommand("Gagnam style");
            return RedirectToAction("Index");
        }

        public ActionResult RapDance()
        {
            CommandHelper.SetCurrentCommand("Rap club");
            return RedirectToAction("Index");
        }

        public ActionResult Avicii()
        {
            CommandHelper.SetCurrentCommand("Avicii dance");
            return RedirectToAction("Index");
        }

        public ActionResult Stop()
        {
            CommandHelper.SetCurrentCommand("Stop");
            return RedirectToAction("Index");
        }

        public string GetCurrentCommand()
        {
            string result = CommandHelper.currentCommand;
            CommandHelper.UnsetCommands();
            return result;
        }
    }
}