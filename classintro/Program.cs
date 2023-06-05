using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "mustafa taha";
            int yas = 240 ;

            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "engindemiro";
            kurs1.Izlenmesayisi = 31;


            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "python";
            kurs2.Egitmen = "berkay";
            kurs2.Izlenmesayisi = 69;


            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "Blender";
            kurs3.Egitmen = "mustafa taha";
            kurs3.Izlenmesayisi = 31;

            //Console.WriteLine(kurs1.Kursadi+" : "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen );

            }


            Console.WriteLine("");

        }
    }

    class Kurs
    {
        public string Kursadi { get; set; }
        public string Egitmen { get; set; }
        public int Izlenmesayisi { get; set; }
    }
}
