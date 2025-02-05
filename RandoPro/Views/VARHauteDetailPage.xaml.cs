using Microsoft.Maui.Graphics.Converters;
using RandoPro.Models;
using System.Globalization;
using System.Windows.Input;

//public Color BackgroundColor { get; set; }

namespace RandoPro.Views { 

    [QueryProperty(nameof(VARHaute), "VARHaute")]
    
    public partial class VARHauteDetailPage : ContentPage {

        //public new Color BackgroundColor { get; set; }

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url)); //edi
        Rando varhaute;
        public Rando VARHaute
        {
            get => varhaute;
            set
            {
                varhaute = value;
                OnPropertyChanged();
            }
        }

        public VARHauteDetailPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }

}
