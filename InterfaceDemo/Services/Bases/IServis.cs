using InterfaceDemo.Models;

namespace InterfaceDemo.Services.Bases
{
    interface IServis
    {
        List<Oyun> Getir();
        void Ekle(Oyun oyun);
    }
}
