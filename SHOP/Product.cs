using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;

namespace SHOP
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public double quality { get; set; }
        public string description { get; set; }
        public BitmapImage pic { get; set; }
        public string category { get; set; }
        public Product(string name, double price, double quality, string description)
        {
            this.name = name;
            this.price = price;
            this.quality = quality;
            this.description = description;
        }
        public Product()
        {

        }
        static Product()
        {

        }
        public bool create_product()
        {

        }
        static public ObservableCollection<Product> GetList()
        {
            

        }
        public static void Upload_products()
        {

        }
    }
}
