using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOtomasyon.Entities.DTOs
{
    public class UrunDTO
    {
        public int UrunId { get; set; }

        public string UrunAdi { get; set; }

        public decimal Fiyat { get; set; }

        public string Kategori { get; set; }

        public bool StoktaVarMi { get; set; }
    }
}
