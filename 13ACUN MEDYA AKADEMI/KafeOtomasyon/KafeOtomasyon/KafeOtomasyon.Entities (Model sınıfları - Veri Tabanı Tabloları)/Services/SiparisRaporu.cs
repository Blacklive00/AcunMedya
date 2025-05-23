using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOtomasyon.Entities.DTOs
{
    public class SiparisRaporu
    {
        public int SiparisId { get; set; }
        public int Kat { get; set; }
        public int MasaNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string OdemeTuru { get; set; }
        public DateTime Tarih { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}

