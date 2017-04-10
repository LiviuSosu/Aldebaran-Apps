using RobotAPIs.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RobotAPIs.Helpers
{
    public static class DataHelper
    {
        public static string Data { get; set; }

        public static string GetDataFronLocalJsonFile()
        {
            string path = HttpContext.Current.Server.MapPath("~/App_Data\\Data.json");
            var content = File.ReadAllText(path);
            return content;
        }

        private static Customer customer = new Customer();
        public static Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }
    }
}
