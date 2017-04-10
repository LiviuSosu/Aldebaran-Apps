using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAPIs.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string ImagePath { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double OfferModel { get; set; }
        public double OldOfferModel { get; set; }
        public double StandardPrice { get; set; }
    }
}
