using RandoPro.Models;

namespace RandoPro.Data
{
    public static class VARHauteData
    {
        public static IList<Rando> VARHaute { get; private set; }

        static VARHauteData()
        {
            VARHaute = new List<Rando>();

            VARHaute.Add(new Rando
            {
                Area = "VAR-Haute",
                Name = "Carmes",
                Details = "txt",
                Image = "les_carmes_barjols_4.jpg",
                //Profil = "http://rando.gustatio.org/wp-content/uploads/rando/profil/Vallon-du-Destel.png",
                Photos = "https://1drv.ms/f/s!ArU8i3XWMaR-kq9wuADewszjlRm6ng?e=q5rGrT",
                //spare = "spare",
                gpxTrack = "http://rando.gustatio.org/wp-content/uploads/rando/routes/.zip",
                Distance = "11",
                Denivele = "440",
                //Niveau = "2.42",
                Color = "#f2a82f",
                //lat = "43.55629",
                //lon = "6.02029",
                Map = "https://www.google.com/maps/d/embed?mid=1CsYzNT6tFFGW8udupTpm1gsTgvMxpyaf&amp;hl=en"
            });

            VARHaute.Add(new Rando
            {
                Area = "VAR-Haute",
                Name = "St. Martin de Pallières",
                Details = "txt",
                Image = "st_martin_de_pallieres_2.jpg",
                //Profil = "http://rando.gustatio.org/wp-content/uploads/rando/profil/Vallon-du-Destel.png",
                Photos = "https://1drv.ms/f/s!ArU8i3XWMaR-kq9xemwyF3a7JtUjew?e=aNd3Pc",
                //spare = "spare",
                gpxTrack = "http://rando.gustatio.org/wp-content/uploads/rando/routes/.zip",
                Distance = "10.1",
                Denivele = "280",
                //Niveau = "1.85",
                Color = "#f2a82f",
                //lat = "43.58464",
                //lon = "5.87149",
                Map = "https://www.google.com/maps/d/embed?mid=1qr0QSJCK-HuOJ1pgxg2QRQ_X9OdqM1C-&amp;hl=en"
            });
        }
    }
}
