﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAPIs.Models
{
    public class Offer
    {
        public int OfferId { get; set; }
        public string OfferName { get; set; }
        public string Calls { get; set; }
        public string Internet { get; set; }
        public string Roaming { get; set; }
        public bool IsRecommended { get; set; }
    }
}
