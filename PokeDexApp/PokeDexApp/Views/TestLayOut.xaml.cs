using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeDexApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Grid = PokeDexApp.Views.Grid;

namespace PokeDexApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestLayOut : ContentPage
	{
		public TestLayOut ()
		{
			InitializeComponent ();
		}

        private void ButtonRelative_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayout());
        }

        private void ButtonGrid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Grid());
        }
        private void ButtonAbsolute_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.AbsoluteLayout());
        }
        private void ButtonStack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }
        private void ButtonFlex_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.FlexView());
        }
    }
}