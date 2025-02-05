using RandoPro.Models;

namespace RandoPro.Data
{
    public static class AlpesdeHauteProvenceData
    {
        public static IList<Rando> AlpesdeHauteProvence { get; private set; }

        static AlpesdeHauteProvenceData()
        {
            AlpesdeHauteProvence = new List<Rando>();

            AlpesdeHauteProvence.Add(new Rando
            {
                Area = "Alpes de Haute Provence",
                Name = "Gorges de Trévans, Estoublons",
                Details = "txt",
                Image = "gorges_de_trevans_37.jpg",
                //Profil = "http://rando.gustatio.org/wp-content/uploads/rando/profil/Vallon-du-Destel.png",
                Photos = "https://1drv.ms/f/s!ArU8i3XWMaR-krAgcFF6CiUQSf327w?e=OYYbAL",
                //spare = "spare",
                gpxTrack = "http://rando.gustatio.org/wp-content/uploads/rando/routes/route-Gorges-de-Trevans-MAY-2021.zip",
                Distance = "14.9",
                Denivele = "930",
                //Niveau = "4.28",
                Color = "#e4732d",
                //lat = "43.94116",
                //lon = "6.23786",
                Map = "https://www.google.com/maps/d/embed?mid=17R7xGns_wfRp8es8ALs8qa_hy1glOEpp&amp;hl=en"
            });

            AlpesdeHauteProvence.Add(new Rando
            {
                Area = "Alpes de Haute Provence",
                Name = "Moustiers St. Marie",
                Details = "txt",
                Image = "moustiers_st_marie_4.jpg",
                //Profil = "http://rando.gustatio.org/wp-content/uploads/rando/profil/Vallon-du-Destel.png",
                Photos = "https://1drv.ms/f/s!ArU8i3XWMaR-krAhjZZ-iE8XG99YHQ?e=nHHRYP",
                //spare = "spare",
                gpxTrack = "http://rando.gustatio.org/wp-content/uploads/rando/routes/route-Moustiers-St.-Marie-Avr-2018.zip",
                Distance ="6.3",
                Denivele = "520",
                //Niveau = "2.19",
                Color = "#f2a82f",
                //lat = "43.84554",
                //lon = "6.22888",
                Map = "https://www.google.com/maps/d/embed?mid=19oP509yt71pW_E99nJKycH31sXvZJ7vt&amp;hl=en"
            });
        }
    }
}
