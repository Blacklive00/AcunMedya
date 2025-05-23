using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KafeOtomasyon.DAL;
using KafeOtomasyon.Entities.Models;

namespace KafeOtomasyon.KafeOtomasyon.DAL__Data_Access_Layer___Veri_Erişim_Katmanı_.repository
{
    public class KullaniciRepository : Repository<Kullanici>
    {
        public KullaniciRepository(KafeDbContext context) : base(context)
        {
        }

        public Kullanici GetByKullaniciAdi(string kullaniciAdi)
        {
            return _context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi);
        }
    }

}
