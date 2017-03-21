using RobotQuiz.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace RobotAPIs.Controllers
{
    public class PhoneStoreController : Controller
    {
        // GET: PhoneStore
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PhoneAuthentication()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PhoneAuthentication(string phoneNumber)
        {
            if(IsPhoneNumberValid(phoneNumber))
            {
                CommandHelper.SetCurrentCommand("PhoneAuthentificated_Pepper");
                return RedirectToAction("next page");
            }
            else
            {
                CommandHelper.SetCurrentCommand("PhoneNotAuthentificated_Pepper");
                return RedirectToAction("PhoneAuthentication");
            }
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            bool result = true;

            for(int i=0; i< phoneNumber.Length;i++)
            {
                if(!Char.IsDigit(phoneNumber[i]))
                {
                    result = false;
                }
            }

            return result;
        }

        public ActionResult CurrentOffer()
        {
            return View();
        }

        public ActionResult Phones()
        {
            return View();
        }

        public ActionResult Offers()
        {
            return View();
        }

        public ActionResult Purchasing()
        {
            return View();
        }
    }
}