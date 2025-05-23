using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KafeOtomasyon.DAL;
using KafeOtomasyon.Entities.Models;

namespace KafeOtomasyon.KafeOtomasyon.DAL__Data_Access_Layer___Veri_Erişim_Katmanı_.repository
{
    public class SiparisRepository : Repository<Siparis>
    {
        public SiparisRepository(KafeDbContext context) : base(context)
        {
        }

        public IEnumerable<Siparis> GetByMasaId(int masaId)
        {
            return _context.Siparisler.Where(s => s.MasaId == masaId).ToList();
        }
    }

}
