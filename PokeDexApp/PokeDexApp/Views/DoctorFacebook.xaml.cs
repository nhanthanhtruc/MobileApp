using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using static PokeDexApp.Models.Doctor;

namespace PokeDexApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DoctorFacebook : ContentPage
    {
        public static string FBToken= "EAAQQfPRksnUBAIz6wcyRy5gL3Rc4PBdQfxfFIyek03YatLS00fB6vtZCA5BryOCffFB3grSL9GZAkIZCF2G6ZC87mZAAZBtArb9Jq8DanyUQNSvF9k0DYYSegy5o0LDstrVZAa1L4wrSTHtNWhout0Ts75mTYnjWdmjdYZC4Xv77J12tfguU5Xbe6cA6ULB8Lhs170xMDENVBMZBbN3sbpKPA";
        public DoctorFacebook()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //using System.Net.Http;
            //using System.Net.Http.Headers;
            var httpCilent = new HttpClient();
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://graph.facebook.com/v3.1/me?fields=id,name,picture,email,birthday");
            request.Method = HttpMethod.Get;
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer",FBToken);
            var response =  await httpCilent.SendAsync(request);
            if(response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                //using Newtonsoft.Json;
                FaceBookProfile profile = JsonConvert.DeserializeObject<FaceBookProfile>(body);
                BindingContext = profile;
            }
        }

        private void ButtonViewPost_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DoctorPost());
        }
    }
}