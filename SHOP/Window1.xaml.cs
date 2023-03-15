using System;
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
            if (this.Password1_textbox.Password != this.Password2_textbox.Password)
            {
                this.Reg_Button.Background = Brushes.Red;
                this.Cancel_Button.Background = Brushes.Red;
                return;
            }


            user = new User();
            user.login = this.Username_textbox.Text;
            user.name = this.Name_textbox.Text;
            user.surname = this.Surname_textbox.Text;
            user.password = this.Password1_textbox.Password;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
