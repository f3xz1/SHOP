using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public double quality { get; set; }
        public string description { get; set; }

        public byte[] pic { get; set; }

        [NotMapped]
        public BitmapImage pic_bitmap { get; set; }
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
            return false;
        }
        public static void Upload_products()
        {

        }
    }
}
