using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SHOP
{
    //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
    public class User
    {
        public int Id { get; set; }
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
        public async Task create_user_async()
        {
            try
            {
                using (AppContext db = new())
                {
                    db.Users.Add(this);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CreateUserThrow");
                throw;
            }
        }
        public  bool create_user()
        {
            try
            {
                using (AppContext db = new())
                {
                    db.Users.Add(this);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CreateUserThrow");
                throw;
            }
            return true;
        }
        public void LoadCustomers()
        {

        }
        public void LoadOrders()
        {

        }
        public void AddOrder()
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
