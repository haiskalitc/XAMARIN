using BaiTap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        LoginModel login;


        public LoginView()
        {
            InitializeComponent();
#if DEBUG
            LiveReload.Init();
#endif
            login = new LoginModel();
            this.stackLayOut.BindingContext = login;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
            //new NavigationPage(new DanhSach());
        }
    }
}