using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model
{
    public class Customer
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string adress { get; set; }
        public Customer(string name, string surname, string email, string phone_number, string adress)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.phone_number = phone_number;
            this.adress = adress;
        }
    }

}
