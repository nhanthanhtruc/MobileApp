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
    public partial class MsPageDetail : ContentPage
    {
        public MsPageDetail()
        {
            InitializeComponent();
            var di =  DependencyService.Get<IDeviceInfo>();
            LabelTest.Text = di.GetPlatform();
        }
    }
}