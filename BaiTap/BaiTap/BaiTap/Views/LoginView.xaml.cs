using BaiTap.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ViewBase
    {
        public LoginView()
        {
            InitializeComponent();
            LoginViewModel login = new LoginViewModel();
            this.stackLayOut.BindingContext = login;

        }
    }
}