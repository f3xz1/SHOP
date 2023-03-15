﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SHOP
{
    /// <summary>
    /// Interaction logic for Shop_List.xaml
    /// </summary>
    public partial class Shop_List : Window
    {
        public Shop_List()
        {
            InitializeComponent();

            using(AppContext db = new())
            {
                Categiries_List.DataContext = db.Product.Select(a => a.category);
            }
        }
    }
}
