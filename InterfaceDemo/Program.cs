using InterfaceDemo.Models;
using InterfaceDemo.Services;
using InterfaceDemo.Services.Bases;

namespace InterfaceDemo
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //IServis servis = new HafizaServis();
            IServis servis = new DosyaServis()
            {
                DosyaYolu = @"C:\Dosyalar\Oyunlar.txt"
            };
            List<Oyun> oyunlar = servis.Getir();
            foreach (Oyun oyun in oyunlar)
            {
                Console.WriteLine($"Adı: {oyun.Adi} \n" +
                    $"Türü: {oyun.Turu}\n" +
                    $"Yapımcısı: {oyun.Yapimcisi}\n" +
                    $"Yapım Yılı: {oyun.YapimYili}\n" +
                    $"{(oyun.OnlineMi ? "Multiplayer" : "Singleplayer")}");
            }

            Oyun oyun1 = new Oyun() 
            {
                Adi = "Total Overdose",
                OnlineMi = false,
                Turu = "Third Person",
                Yapimcisi = "Deadline Games",
                YapimYili = "2005"
            };
            servis.Ekle(oyun1);

            oyunlar = servis.Getir();
            foreach (Oyun oyun in oyunlar)
            {
                Console.WriteLine($"Adı: {oyun.Adi} \n" +
                    $"Türü: {oyun.Turu}\n" +
                    $"Yapımcısı: {oyun.Yapimcisi}\n" +
                    $"Yapım Yılı: {oyun.YapimYili}\n" +
                    $"{(oyun.OnlineMi ? "Multiplayer" : "Singleplayer")}");
            }
        }
    }
}