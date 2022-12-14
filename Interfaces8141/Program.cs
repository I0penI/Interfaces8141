namespace Interfaces8141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInsan insan = new Ogrenci();

            insan.Adi = "Ali";
            insan.Soyadi = "Arslan";
            Console.WriteLine(insan.AdSoyadGetir());
            insan = new Veli()
            {
                Adi = "Elif",
                Soyadi = "Arslan"
            };
            Console.WriteLine(insan.AdSoyadGetir());
        }
    }
    interface IInsan
    {
        string Adi { get; set; }
        string Soyadi { get; set; }

        string AdSoyadGetir();
    }
    class Ogrenci : IInsan
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string AdSoyadGetir()
        {
            return Adi + " " + Soyadi;
        }
    }
    class Veli : IInsan
    {
        public string Adi { get ; set ; }
        public string Soyadi { get ; set; }

        public string AdSoyadGetir()
        {
            return Adi + " " + Soyadi;
        }
    }
}