using RandoPro.Models;
using System.Windows.Input;

namespace RandoPro.Views
{
    [QueryProperty(nameof(AlpesdeHauteProvence), "AlpesdeHauteProvence")]
    public partial class AlpesdeHauteProvenceDetailPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url)); //edi
        Rando alpesdehauteprovence;
        public Rando AlpesdeHauteProvence
        {
            get => alpesdehauteprovence;
            set
            {
                alpesdehauteprovence = value;
                OnPropertyChanged();
            }
        }

        public AlpesdeHauteProvenceDetailPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
