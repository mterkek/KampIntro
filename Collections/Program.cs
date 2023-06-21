using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl k ctrl c command satırı yapar seçili satırları geri almak için ctrl k ctrl u
            //string[] names = new string[] {"mustafa","burak","ertuğrul"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            List<string> names2 = new List<string> { "taha", "furkan", "faruk" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("ayhan");
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[1]);

        }
    }
}
