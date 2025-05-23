using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOtomasyon.KafeOtomasyon.Entities__Model_sınıfları___Veri_Tabanı_Tabloları_.Models
{
    public class SiparisKalemi
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }
    }
}