using Newtonsoft.Json;
using PokeDexApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeDexApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductAPI : ContentPage
	{
        public static ObservableCollection<Product> products { get; set; }
        public ProductAPI ()
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
            request.RequestUri = new Uri("http://localhost:5000/api/northwind/WithCategory");
            request.Method = HttpMethod.Get;            
            var response = await httpCilent.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                //using Newtonsoft.Json;
                Product product = JsonConvert.DeserializeObject<Product>(body);
                BindingContext = product;
            }
        }
    }
}