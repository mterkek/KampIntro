using System;

namespace KampIntro
{
    class Program
    {
        //private const char V = 'Kategori';

        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repeat yourself
            //değer tutucu , alias

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarbugun = 7.45;

            if (dolarDun < dolarbugun)
            {
                Console.WriteLine("azalış simgesi");
            }
            else if (dolarbugun < dolarDun) 
            {
                Console.WriteLine("artış simgesi");
            }
            else
            {
                Console.WriteLine("eşittir");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("kulanıcı olarak girdi butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

        }
    }
}
