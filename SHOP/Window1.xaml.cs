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


//add-migration nn
//update

namespace SHOP
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public User user { get; set; }
        public Window1()    
        {
            InitializeComponent();
        }

        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            user = new User();
            
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
