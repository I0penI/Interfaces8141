using InterfaceDemo.Data;
using InterfaceDemo.Models;
using InterfaceDemo.Services.Bases;

namespace InterfaceDemo.Services
{
    internal class HafizaServis : IServis
    {
        public void Ekle(Oyun oyun)
        {
            OyunData.Oyunlar.Add(oyun);
        }

        public List<Oyun> Getir()
        {
            return OyunData.Oyunlar;
        }
    }
}
