using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOtomasyon.Core.DTOs
{
    public class KullaniciDTO
    {
        public int KullaniciId { get; set; }

        public string KullaniciAdi { get; set; } = string.Empty;

        public string Sifre { get; set; } = string.Empty;

        public string YetkiTipi { get; set; } = string.Empty;
    }
}

