using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaiTap.Model
{
    public class LoginModel:INotifyPropertyChanged
    {
        private string username;
        private string password;
        private ICommand command;

        public string Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChange(Password);
                }
            }
        }
        public string Username { get => username; set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChange(Username);
                    if(Command!=null)
                    ((Command)Command).ChangeCanExecute();
                }
            }
        }

        public ICommand Command { get => command; set => command = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginModel()
        {
            this.Username = "HAI";
            this.Password = "123456";
            Command = new Command(CheckButton,CanExcute);

        }
        public void OnPropertyChange(string pro)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(pro)));
            }
        }
        private bool CanExcute(object args)
        {
            if (string.IsNullOrEmpty(Username))            
            {
                return false;
            }
            return true;
        }

        public void  CheckButton(object args)
        {
        }
        public LoginModel(string username, string password, ICommand command)
        {
            Username = username;
            Password = password;
            this.Command = command;
        }
    }
}
