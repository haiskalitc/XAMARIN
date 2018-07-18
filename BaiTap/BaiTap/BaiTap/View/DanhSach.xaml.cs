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
	public partial class DanhSach : ContentPage
	{
		public DanhSach ()
		{
			InitializeComponent ();
#if DEBUG
            LiveReload.Init();
#endif
        }
    }
}