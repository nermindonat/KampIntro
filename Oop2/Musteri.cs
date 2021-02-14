using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //classlarda operasyonlar ve özellikler olur. özelliklerin olduğu yerde operasyonlar olmaz.
    //Eğer bir veri üzerinde işlem yapmiyorsan MusteriNo gibi bunun tipine string yaz.
    //Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan o nesneye ait değilmiş gibi duruyorsa o alan demek ki orada hata yapıyorsun.
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
