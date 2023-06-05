using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 
            string kurs1 = "yazılım geliştirici kurss";
            string kurs1 = "yazılım başlangıç kursu";
            string kurs3 = "java";
           */
            //array- dizi

            string[] kurslar = new string[] { "yazılım geliştirici kurss",
            "yazılım başlangıç kursu","java"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");
        }
    }
}
