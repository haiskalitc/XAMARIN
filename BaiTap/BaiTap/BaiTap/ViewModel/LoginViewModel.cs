using BaiTap.MVV;
using BaiTap.MVVM.Command;
using BaiTap.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BaiTap.ViewModel
{
    public class LoginViewModel : BindableBase
    {
        /// <summary>
        /// Field
        /// </summary>
        private string username;
        private string password;
        private bool isBusy;
        public bool IsNotBusy => !isBusy;
        public DelegateCommand<object> LoginCommand { get; set; }


        /// <summary>
        /// Property
        /// </summary>
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                SetProperty(ref isBusy, value,
() => { RaisePropertyChanged(nameof(IsNotBusy)); });
            }
        }
        public string Username { get { return username; } set { SetProperty(ref username, value); } }
        public string Password { get { return password; } set { SetProperty(ref password, value); } }


        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand<object>(LoginExcute, CanExute)
                .ObservesProperty(() => Username)
                .ObservesProperty(() => Password)
                .ObservesProperty(() => IsBusy);
        }

        private bool CanExute(object arg)
        {
            return true;
        }

        private void LoginExcute(object obj)
        {
            var item = obj as string;
            switch (item)
            {
                case "Login":
                    {
                        ((NavigationPage)Application.Current.MainPage).PushAsync(new NavigationPage(new TrangChu()));
                        break;
                    }
                case "Account":
                    {
                        break;
                    }
            }
        }
    }
}
