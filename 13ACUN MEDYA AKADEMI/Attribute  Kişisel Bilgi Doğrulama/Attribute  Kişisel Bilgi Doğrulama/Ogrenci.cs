using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute__Kişisel_Bilgi_Doğrulama
{
    public class Ogrenci
    {
        [GerekliAlan("Ad alanı boş geçilemez.")]
        public string Ad { get; set; }

        [GerekliAlan("Soyad alanı boş geçilemez.")]
        public string Soyad { get; set; }

        [GerekliAlan("Bölüm alanı boş geçilemez.")]
        public string Bolum { get; set; }
    }

}
