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
	public partial class DoctorDetail : ContentPage
	{
        private Doctor Doctor { get; set; }
        public DoctorDetail (Doctor doctor)
		{
			InitializeComponent ();
            Doctor = doctor;
            Image.Source = Doctor.Image;
            Name.Text = Doctor.Name;
            Title.Text = Doctor.Title;
            Phone.Text = Doctor.Phone;
            Address.Text = Doctor.Address;


        }
        public DoctorDetail()
        {
            InitializeComponent();            

        }
    }
}