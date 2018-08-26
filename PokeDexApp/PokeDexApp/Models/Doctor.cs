using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace PokeDexApp.Models
{
    public partial class Doctor : INotifyPropertyChanged
    {
        private string _Phone;
        public string Phone
        {
            get => _Phone;
            set
            {
                if (_Phone != value)
                {
                    _Phone = value;
                    RaisePropertyChanged(nameof(Phone));
                }
            }
        }
        public string Name { get; set; }    
        public string Title { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged (string PropertyName)
        {
            //if (PropertyChanged != null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
