using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace KafeOtomasyon.Entities.DTOs
{
    public class SiparisDTO
    {
        public int SiparisId { get; set; }

        public int MasaId { get; set; }

        public int UrunId { get; set; }

        public int Adet { get; set; }

        public DateTime SiparisTarihi { get; set; }

        public string UrunAdi { get; set; }  // Gösterim amaçlı, siparişle beraber ürün adı da taşınabilir

        public decimal ToplamFiyat { get; set; }
    }
}
