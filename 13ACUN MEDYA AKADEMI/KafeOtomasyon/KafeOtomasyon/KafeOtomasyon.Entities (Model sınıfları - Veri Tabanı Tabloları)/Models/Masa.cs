using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KafeOtomasyon.Entities.Models
{
    public class Masa
    {
        [Key]
        public int MasaId { get; set; }

        public int Kat { get; set; }

        public int MasaNo { get; set; }

        public MasaDurumu Durum { get; set; }


        public ICollection<Siparis> Siparisler { get; set; }

        public Masa()
        {
            Siparisler = new List<Siparis>();
        }
    }

    public enum MasaDurumu
    {
        Bos = 0,
        Dolu = 1,
        Rezerve = 2
    }
}
