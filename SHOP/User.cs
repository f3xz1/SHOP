using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SHOP
{
    public class User
    {
        public string login { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }

        public List<Product> qwe { get; set; }

        public User(string login, string password, string name, string surname)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.surname = surname;
        }
        public User()
        {

        }
        public bool create_user()
        {
            if (File.Exists(IFiled.user_path + "\\" + login + $"\\{login}.json"))
            {
                return false;
            }
            try
            {
                Directory.CreateDirectory(IFiled.user_path + "\\" + login);
                File.Create(IFiled.user_path + "\\" + login + "\\Customers.json").Close();
                File.Create(IFiled.user_path + "\\" + login + "\\Orders.json").Close();
                JsonSerializer serializer = new JsonSerializer();

                using (StreamWriter file = new StreamWriter(IFiled.user_path + "\\" + login + $"\\{login}.json", false))
                {
                    serializer.Serialize(file, this);
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("register break");
            }
        }
        public void LoadCustomers()
        {

        }
        public void AddCustomer(Customer customer)
        {

        }
        public void LoadOrders()
        {

        }
        public void AddOrder(Order order)
        {

        }
        public void Update_Orders()
        {

        }
        public void Upload_Customers()
        {

        }
    }
}
