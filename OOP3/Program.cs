using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();          
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());   //seçtiğimiz krediye göre kredi faiz hesaplatıyoruz gibi düşün bu noktayı 


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , tasitKrediManager}; //burası da ihtiyaç kredisi seçtiğimiz krediye göre kredi faiz hesaplatıyoruz gibi düşün bu noktayı

          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);




        }
    }
}
