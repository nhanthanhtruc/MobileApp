using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeDexApp
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
                        Phone="xxx.xxx.xxx",
                        Image ="https://image.freepik.com/free-photo/doctor-smiling-with-stethoscope_1154-36.jpg"

                    },new Doctor()
                    {
                        Name="Nguyen Van B",
                        Title="Y Ta",
                        Address="Can Tho",
                        Phone="xxx.xxx.xxx",
                        Image="https://www.carwreckdoctor.com/hubfs/Car_Accident_Doctor.png?t=1534449952862"
                    }
                };
            };
            ListViewDoctor.ItemsSource = doctor;
            
		}

        private void ListViewDoctor_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var doctor = (Doctor)e.Item;
            Navigation.PushAsync(new DoctorDetail(doctor));
        }
    }
}