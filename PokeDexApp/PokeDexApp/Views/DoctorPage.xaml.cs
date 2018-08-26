using PokeDexApp.Models;
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
	public partial class DoctorPage : ContentPage
	{ 
        List<Doctor> doctor { get; set; }
		public DoctorPage ()
		{
			InitializeComponent ();
            if(doctor== null)
            {
                doctor = new List<Doctor>()
                {
                    new Doctor()
                    {
                        Name="Nguyen Van A",
                        Title="Bac Si",
                        Address="Can Tho",
                        Phone="+84948109922",
                        Image ="https://image.freepik.com/free-photo/doctor-smiling-with-stethoscope_1154-36.jpg"

                    },new Doctor()
                    {
                        Name="Nhu Tran",
                        Title="Bac Si",
                        Address="Can Tho",
                        Phone="+84919165900",
                        Image="https://www.carwreckdoctor.com/hubfs/Car_Accident_Doctor.png?t=1534449952862"
                    }
                };
            };
            ListViewDoctor.ItemsSource = doctor;
            //ListViewDoctor.IsPullToRefreshEnabled = true;
            //Users have come to expect that pulling down on a list of data will refresh that list.
            //ListView supports this out-of - the - box.To enable pull-to - refresh functionality, set IsPullToRefreshEnabled to true
        }

        private void ListViewDoctor_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var doctor = (Doctor)e.Item;
            Navigation.PushAsync(new DoctorDetail(doctor));
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListViewDoctor.ItemsSource = doctor;
        }
        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");            
            doctor.Add(
                new Doctor()
                {
                    Name = "Nhu Tran",
                    Title = "Bac Si",
                    Address = "Can Tho",
                    Phone = "+84919165900",
                    Image = "https://www.carwreckdoctor.com/hubfs/Car_Accident_Doctor.png?t=1534449952862"
                }
            );
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }
    }
}