using MyShare;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeDexApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class CategoryAPI : ContentPage
	{       
        public CategoryAPI ()
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
            request.RequestUri = new Uri("http://172.16.51.74:8090/api/northwind/Category");
            request.Method = HttpMethod.Get;
            var response = await httpCilent.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                //using Newtonsoft.Json;
                var category = JsonConvert.DeserializeObject<List<Category>>(body);
                BindingContext = category;
            }
        }
    }
}