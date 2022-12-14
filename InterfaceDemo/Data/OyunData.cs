using InterfaceDemo.Models;

namespace InterfaceDemo.Data
{
    static class OyunData
    {
        public static List<Oyun> Oyunlar { get; set; } = new List<Oyun>()
        {
            new Oyun()
            {
                Adi = "SIMS",
                OnlineMi = false,
                Turu = "Simulasyon",
                Yapimcisi = "EA",
                YapimYili = "2000"
            },
            new Oyun()
            {
                Adi = "Crysis",
                OnlineMi = false,
                Turu = "FPS",
                Yapimcisi = "CRYTEK",
                YapimYili = "2007"
            },
            new Oyun()
            {
                Adi = "RDR Online",
                OnlineMi = true,
                Turu = "RPG",
                Yapimcisi = "Rockstar Games",
                YapimYili = "2015"
            },

        };
    }
}
