using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyve = new string[] { };
            

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 1;
            urun1.Aciklama = "Ama";

            Product urun2 = new Product();
            urun2.Adi = "kayısı";
            urun2.Aciklama = "malatya";

            Product[] urunler = new Product[] { urun1, urun2 };


            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------");
            }

            Console.WriteLine("...............metotlar.............");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("kuru kayısı","kupkuru",20);



        }
    }
}
