using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate=Tüzel müşteri
    class TuzelMusteri:Musteri    //İnheritance-miras-kalıtım
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
