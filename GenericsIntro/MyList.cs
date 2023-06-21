using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //ctor yaz tab tab yap constructor yani yapıcı method
        public MyList()
        {
            items = new T[0]; //
        }
        public void Add(T item)
        {
            //burda generic list yapmaya çalışıyoz gardaş
            //temporary array geçici dizi 
            T[] tempArray = items;
            items = new T[items.Length+1]; //dizinin mevcut elaman sayıwsını bir artırıyorum
            //temporary olarak tuttuğumuz değerleri for döngüsüyle items a geri alcaz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //aslında eklemek istenen elemanı şuan ekledik
        }

    }
}
