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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.EntityFrameworkCore;

namespace SHOP
{
    /// Scaffold-DbContext "Server=.\;Database=AdventureWorksLT2012;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model -Context "AdventureContext" -DataAnnotations


    // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=                   ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False


    public partial class MainWindow : Window
    {
        public User user { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new();
            window1.ShowDialog();
            user = window1.user;
            if (user != null)
            {
                var res = user.create_user_async();
                this.Login_textbox.Text = user.login;
                this.Password_textbox.Password = user.password;
            }
        }

        private void Log_Button_Click(object sender, RoutedEventArgs e)
        {
            using(AppContext appContext = new AppContext())
            {
                if(appContext.Users.Select(a=>a.login == this.user.login && a.password==this.user.password) != null)
                {
                    //main prog open
                    Shop_List shop_List = new();
                    this.Close();
                    shop_List.Show();
                }
                else
                {
                    this.wrong_info.Visibility = Visibility.Visible;
                }
            }
        }

        private void Password_textbox_GotFocus(object sender, RoutedEventArgs e) // delete or finish
        {
            this.Background = Brushes.AliceBlue;
        }
    }
}
