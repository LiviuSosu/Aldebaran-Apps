using Newtonsoft.Json;
using RobotAPIs.Helpers;
using RobotAPIs.Models;
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
        //public ActionResult Index()
        //{
        //    DataHelper.Data = DataHelper.GetDataFronLocalJsonFile();
        //    return View();
        //}
        string sData = DataHelper.GetDataFronLocalJsonFile();

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
                Data data = JsonConvert.DeserializeObject<Data>(sData);
                var customer = data.Customers.Where(x=>x.PhoneNumber== phoneNumber).SingleOrDefault();
                if (customer!=null)
                {
                    DataHelper.Customer = customer;
                    return RedirectToAction("CurrentOffer");
                }
                else
                {
                    return Redirect(Request.UrlReferrer.PathAndQuery);
                }
            }
            else
            {
                CommandHelper.SetCurrentCommand("InvalidPhoneNumbuer_Pepper");
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

        public ActionResult CurrentOffer(int? customerId)
        {
            var offer = DataHelper.Customer.Offer;
            return View(offer);
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