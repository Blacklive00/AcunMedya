using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KafeOtomasyon.Entities.Models
{
    public class Siparis
    {
        [Key]
        public int SiparisId { get; set; }

        public int MasaId { get; set; }
        [ForeignKey(nameof(MasaId))]
        public Masa Masa { get; set; }

        public int KullaniciId { get; set; }
        [ForeignKey(nameof(KullaniciId))]
        public Kullanici Kullanici { get; set; }

        public int OdemeTuruId { get; set; }
        [ForeignKey(nameof(OdemeTuruId))]
        public OdemeTuru OdemeTuru { get; set; }

        public DateTime Tarih { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(10,2)")]
        public decimal ToplamTutar { get; set; }

        // Navigation: Bu siparişin detayları (hangi ürünler, kaç adet, vb.)
        public ICollection<SiparisDetay> SiparisDetaylari { get; set; }
    }
}
