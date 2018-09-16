using PokeDexApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static PokeDexApp.Models.Doctor;
using static PokeDexApp.Views.DoctorFacebook;
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
        private async void ButtonFacebookLogin_Clicked(object sender, EventArgs e)
        {
            var facebookProvider = DependencyService.Get<IFacebookService>();
            bool result = await facebookProvider.LoginAsync();
            if (result==true)
            {
                var userId = facebookProvider.UserId;
                var accessToken = facebookProvider.AccessToken;
                FacebookLogin.Text = userId;
                FBToken = accessToken;
            }
        }
    }
}