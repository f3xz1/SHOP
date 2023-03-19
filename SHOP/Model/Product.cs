using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;

namespace SHOP.Model
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
        public Product(string name, double price, double quality, string description, string category)
        {
            this.name = name;
            this.price = price;
            this.quality = quality;
            this.description = description;
            this.category = category;
        }
        //public Product()
        //{

        //}
        public bool create_product()
        {
            try
            {
                using (AppContext db = new())
                {
                    db.Product.Add(this);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CreateProductThrow");
                throw;
            }
            return true;
        }

        //private async Task LoadPictureAsync(byte[] pic)
        //{
        //    try
        //    {
        //        using (var ms = new MemoryStream(pic))
        //        {
        //            this.pic_bitmap.BeginInit();
        //            this.pic_bitmap.StreamSource = ms;
        //            this.pic_bitmap.EndInit();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private byte[] CreateCopy()
        //{
        //    Image image = Image.FromFile(FileName);
        //    int maxWidth = 300,maxHeight = 300;
        //    double ratioX = (double)maxWidth / image.Width;
        //    double ratioY = (double)maxHeight / image.Height;
        //    double ratio = Math.Min(ratioX, ratioY);
        //    int newWidth = (int)(image.Width * ratio);
        //    int newHeight = (int)(image.Height * ratio);
        //    Image myImage = new Bitmap(newWidth, newHeight);
        //    Graphics graphics = Graphics.FromImage(myImage);
        //    graphics.DrawImage(image, newWidth, newHeight);
        //    MemoryStream memorystream = new MemoryStream();
        //    myImage.Save(memorystream, ImageFormat.Jpeg);
        //    memorystream.Flush(); 
        //    BinaryReader binaryReader = new BinaryReader(memorystream);
        //    byte[] bytes = binaryReader.ReadBytes((int)memorystream.Length);
        //    return bytes;
        //}



    }
}
//monitor - lock

//Thread - ThreadPool

// Task

// asinc await

// Mutex 

// simaphore (slim)