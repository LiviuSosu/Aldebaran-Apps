using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;

namespace Experiments
{
    public class Program
    {
        public void Main(string[] args)
        {
            GenerateData();
        }


        private static string GenerateData()
        {
            string data = "";
            List<Offer> offers = new List<Offer>();
            List<Customer> customers = new List<Customer>();
            List<Phone> phones = new List<Phone>();

            Offer offer1 = new Offer();
            offer1.OfferId = 1;
            offer1.Internet = "500 MB";
            offer1.Calls = "300 Minutes and 300 SMS/MMS";
            offer1.IsRecommended = false;
            offer1.OfferName = "Standard offer";
            offer1.Roaming = "10 minutes for international calls";
            offers.Add(offer1);

            Offer offer2 = new Offer();
            offer2.OfferId = 2;
            offer2.Internet = "700 MB";
            offer2.Calls = "300 Minutes and 450 SMS/MMS";
            offer2.IsRecommended = false;
            offer2.OfferName = "Play 20";
            offer2.Roaming = "20 minutes for international calls";
            offers.Add(offer2);

            Offer offer3 = new Offer();
            offer3.OfferId = 3;
            offer3.Internet = "1 GB";
            offer3.Calls = "400 Minutes and 600 SMS/MMS";
            offer3.IsRecommended = true;
            offer3.OfferName = "Play 30";
            offer3.Roaming = "40 minutes for international calls";
            offers.Add(offer3);

            Offer offer4 = new Offer();
            offer4.OfferId = 4;
            offer4.Internet = "2 GB";
            offer4.Calls = "600 Minutes and 1000 SMS/MMS";
            offer4.IsRecommended = false;
            offer4.OfferName = "Play 40";
            offer4.Roaming = "60 minutes for international calls";
            offers.Add(offer4);

            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.FirstName = "John";
            customer1.LastName = "Smith";
            customer1.PhoneNumber = "0634568899";
            customer1.Offer = offer1;
            customers.Add(customer1);

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.FirstName = "Frank";
            customer2.LastName = "Sinatra";
            customer2.PhoneNumber = "0634568894";
            customer2.Offer = offer1;
            customers.Add(customer2);

            Phone phone1 = new Phone();
            phone1.PhoneId = 1;
            phone1.Brand = "Apple";
            phone1.ImagePath = "Phone1.jpg";
            phone1.Model = "iPhone 7 Black";
            phone1.OfferModel = 299.90;
            phone1.OldOfferModel = 399.90;
            phone1.StandardPrice = 1000.00;
            phones.Add(phone1);

            Phone phone2 = new Phone();
            phone2.PhoneId = 2;
            phone2.Brand = "Apple";
            phone2.ImagePath = "Phone2.jpg";
            phone2.Model = "iPhone  Silver";
            phone2.OfferModel = 59.90;
            phone2.OldOfferModel = 99.90;
            phone2.StandardPrice = 120.00;
            phones.Add(phone2);

            Phone phone3 = new Phone();
            phone2.PhoneId = 3;
            phone2.Brand = "Apple";
            phone2.ImagePath = "Phone3.jpg";
            phone2.Model = "iPhone 7 Goled Rose";
            phone2.OfferModel =69.90;
            phone2.OldOfferModel =89.90;
            phone2.StandardPrice = 1100.00;
            phones.Add(phone3);

            Data _data = new Data();
            _data.Customers = customers;
            _data.Offers = offers;
            _data.Phones = phones;

            data = Newtonsoft.Json.JsonConvert.SerializeObject(_data);

            return  data;
        }
    }
}
