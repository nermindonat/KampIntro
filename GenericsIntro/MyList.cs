using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //burdaki T tip(type) ten geliyor. 
    class MyList<T>
    {
        T[] items;
        public MyList()              //ctor + tab tab yap bu yapı gelir. constructor:bir metottur. classın ismiyle aynıdır.
        {
            items = new T[0];       // new lediğin anda çalışan bloğa constructor denir. new lediğin anda array ı sıfırlıyorsun.
        }
        public void Add(T item)
        {
            //temparray=geçici dizi
            T[] tempArray = items;
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
