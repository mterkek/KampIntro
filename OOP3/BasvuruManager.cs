using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection yapıyoruz burda soyut hallerini somut halde enjekte ediyoruz
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme
            //kredinin referansına göre çalışır
            krediManager.Hesapla();
            loggerService.Log();

            
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
