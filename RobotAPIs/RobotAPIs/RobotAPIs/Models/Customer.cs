using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAPIs.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        private Offer offer = new Offer();
        public Offer Offer
        {
            get
            {
                return offer;
            }
            set
            {
                offer = value;
            }
        }
    }
}
