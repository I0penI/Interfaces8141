using InterfaceDemo.Models;
using InterfaceDemo.Services.Bases;

namespace InterfaceDemo.Services
{
    internal class DosyaServis : IServis
    {
        public string DosyaYolu { get; set; }
        public List<Oyun> Getir()
        {
            List<Oyun> oyunlar = new List<Oyun>();
            string[] satirlar = File.ReadAllLines(DosyaYolu);
            string[] veriler;
            Oyun oyun;
            foreach (string satir in satirlar)
            {
                veriler = satir.Split('~');
                oyun = new Oyun()
                {
                    Adi = veriler[0],
                    OnlineMi = Convert.ToBoolean(veriler[1]),
                    Turu = veriler[2],
                    Yapimcisi = veriler[3],
                    YapimYili = veriler[4]
                };
                oyunlar.Add(oyun)
            }
            return oyunlar;
        }
    }
}
