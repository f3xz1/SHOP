using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.ViewModel
{
    class LoginViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public string Login { 
            get 
            {
                return this.Login;
            }
            set 
            {
                this.Login = value;
                OnPropertyChanged(Login);
            }
             }
        public string Password
        {
            get
            {
                return this.Password;
            } 
            set
            {
                this.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
