using RandoPro.Models;

namespace RandoPro.Views
{
    public partial class AlpesdeHauteProvencePage : ContentPage
    {
        public AlpesdeHauteProvencePage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Rando rando = e.CurrentSelection.FirstOrDefault() as Rando;

            var navigationParameter = new Dictionary<string, object>
            {
                { "AlpesdeHauteProvence", rando }
            };
            await Shell.Current.GoToAsync($"alpesdehauteprovencedetails", navigationParameter);
        }
    }
}
