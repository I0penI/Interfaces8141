using InterfaceDemo.Data;
using InterfaceDemo.Models;
using InterfaceDemo.Services.Bases;

namespace InterfaceDemo.Services
{
    internal class HafizaServis : IServis
    {
        public List<Oyun> Getir()
        {
            return OyunData.Oyunlar;
        }
    }
}
