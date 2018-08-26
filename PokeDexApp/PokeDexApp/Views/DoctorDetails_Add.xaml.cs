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
	public partial class DoctorDetails_Add : ContentPage
	{
		public DoctorDetails_Add ()
		{
			InitializeComponent ();
		}
        private void ButtonSave_Clicked(object sender, EventArgs e)
        {
            DoctorPage.doctor.Add(
                new Doctor()
                {
                    Name = Name.Text,
                    Title = Title.Text,
                    Address = Address.Text,
                    Phone = Phone.Text,
                    Image = "https://www.carwreckdoctor.com/hubfs/Car_Accident_Doctor.png?t=1534449952862"
                }
            );
            Navigation.PopAsync();
        }
    }
}