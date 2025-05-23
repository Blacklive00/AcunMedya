using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOtomasyon.KafeOtomasyon.Entities__Model_sınıfları___Veri_Tabanı_Tabloları_.Models
{
    public class Urun1
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }

        public string DisplayText => $"{Ad} - Fiyat: {Fiyat:C} - Stok: {Stok}";

        public override string ToString() => DisplayText;
    }
}
