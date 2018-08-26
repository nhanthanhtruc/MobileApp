using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static PokeDexApp.Models.Doctor;

namespace PokeDexApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorPost : ContentPage
	{
		public DoctorPost ()
		{
			InitializeComponent ();
		}
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //using System.Net.Http;
            //using System.Net.Http.Headers;
            var httpCilent = new HttpClient();
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://graph.facebook.com/v3.1/me?fields=posts{full_picture,message}");
            request.Method = HttpMethod.Get;
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", DoctorFacebook.FBToken);
            var response = await httpCilent.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                //using Newtonsoft.Json;
                FaceBookPost profile = JsonConvert.DeserializeObject<FaceBookPost>(body);
                BindingContext = profile;
            }
        }
    }
}