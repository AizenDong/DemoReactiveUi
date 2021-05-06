using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoReactiveUi
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _userName;

        public string UserName  
        {
            get { return _userName; }
            set 
            {
                _userName = value; 
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
