using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    // Loglama??  ---> kimin ne zaman hangi operasyanu çağırmasıdır. Yani o sistemde olan hareketleri döktüğümüz bir dökümdür.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
