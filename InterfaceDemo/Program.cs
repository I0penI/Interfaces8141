using InterfaceDemo.Models;
using InterfaceDemo.Services;
using InterfaceDemo.Services.Bases;

namespace InterfaceDemo
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            IServis servis = new HafizaServis();
            List<Oyun> oyunlar = servis.Getir();
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