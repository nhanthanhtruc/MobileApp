using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeDexApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        private void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            if (UserName.Text == "abc" && PassWord.Text == "123")
            {
                App.Current.MainPage = new MsPage();
            }
            else
            {
                DisplayAlert("Error", "Wrong Username or Password", "Ok");
            }
        }
    }
}