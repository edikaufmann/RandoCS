using RandoPro.Models;

namespace RandoPro.Views
{
    public partial class VARHautePage : ContentPage
    {
        
        public VARHautePage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Rando rando = e.CurrentSelection.FirstOrDefault() as Rando;

            var navigationParameter = new Dictionary<string, object>
            {
                { "VARHaute", rando }
            };
            await Shell.Current.GoToAsync($"varhautedetails", navigationParameter);
        }
    }
}
