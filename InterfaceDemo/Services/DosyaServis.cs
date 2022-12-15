using InterfaceDemo.Models;
using InterfaceDemo.Services.Bases;

namespace InterfaceDemo.Services
{
    internal class DosyaServis : IServis
    {
        const string AYRAC = "~";
        public string DosyaYolu { get; set; }

        public void Ekle(Oyun oyun)
        {
            string satir = "\n" + oyun.Adi + AYRAC + oyun.OnlineMi + AYRAC + oyun.Turu + AYRAC + oyun.Yapimcisi + AYRAC + oyun.YapimYili;

            // 1. yöntem
            // string satir = "\n" + oyun.Adi + AYRAC + oyun.OnlineMi + AYRAC + oyun.Turu + AYRAC + oyun.Yapimcisi + AYRAC + oyun.YapimYili;
            // File.AppendAllText(DosyaYolu , satir);

            // 2. yöntem
            // StreamWriter writer = new StreamWriter(DosyaYolu, true);
            // writer.WriteLine(satir);
            // writer.Close();

            // 3. yöntem , Close yapmasak da olur
            using (StreamWriter writer = new StreamWriter(DosyaYolu, true))
            {
                writer.Write(satir);
            }
        }

        public List<Oyun> Getir() 
        {
            List<Oyun> oyunlar = new List<Oyun>();
            #region 1. yöntem
            //1. yöntem
            //string[] satirlar = File.ReadAllLines(DosyaYolu);
            #endregion
            //2. yöntem
            List<string> satirListesi = new List<string>();
            using (StreamReader reader = new StreamReader(DosyaYolu))
            {
                
                /*string icerik = reader.ReadToEnd();*/ // istenirse dosya içeriği son satıra kadar okunup tek string olarak dönülebilir
                string satir;
                int i = 1;
                while((satir = reader.ReadLine()) is not null) // != null, while(!reader.EndOfStream)
                {
                    satirListesi.Add(i++ + ")" + satir);
                }
            }
            string[] satirlar = satirListesi.ToArray();

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
                oyunlar.Add(oyun);
            }
            return oyunlar;
        }
    }
}
