using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAPIs.Models
{
    public class Data
    {

        private List<Customer> customers = new List<Customer>();
        private List<Offer> offers = new List<Offer>();
        private List<Phone> phones = new List<Phone>();

        public List<Customer> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
            }
        }

        public List<Offer> Offers
        {
            get
            {
                return offers;
            }
            set
            {
                offers = value;
            }
        }

        public List<Phone> Phones
        {
            get
            {
                return phones;
            }
            set
            {
                phones = value;
            }
        }
    }
}
