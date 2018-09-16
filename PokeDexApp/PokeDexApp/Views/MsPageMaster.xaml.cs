using PokeDexApp.Models;
using PokeDexApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokeDexApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MsPageMaster : ContentPage
    {
        public ListView ListView;

        public MsPageMaster()
        {
            InitializeComponent();

            BindingContext = new MsPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MsPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MsPageMenuItem> MenuItems { get; set; }
            
            public MsPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MsPageMenuItem>(new[]
                {
                    new MsPageMenuItem { Id = 0, Title = "PokeDex" ,TargetType=typeof(MainPage)},
                    new MsPageMenuItem { Id = 1, Title = "Test LayOut",TargetType=typeof(TestLayOut) },
                    new MsPageMenuItem { Id = 2, Title = "Doctor",TargetType=typeof(DoctorPage) },
                    new MsPageMenuItem { Id = 3, Title = "Binding",TargetType=typeof(BindingView) },
                    new MsPageMenuItem { Id = 4, Title = "CategoryAPI",TargetType=typeof(CategoryAPI) },
                    new MsPageMenuItem { Id = 5, Title = "LoginPage",TargetType=typeof(LoginPage) },
                    new MsPageMenuItem { Id = 6, Title = "About" },
                    
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}