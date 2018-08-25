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
            Navigation.PushAsync(new Grid());
        }
        private void ButtonAbsolute_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayout());
        }
        private void ButtonStack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }
        private void ButtonFlex_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexView());
        }
    }
}