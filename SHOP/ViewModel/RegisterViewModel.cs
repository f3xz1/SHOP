using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.ViewModel
{
    class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Login { get; set; }
        public string Password_1 { get; set; }
        public string Password_2 { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
