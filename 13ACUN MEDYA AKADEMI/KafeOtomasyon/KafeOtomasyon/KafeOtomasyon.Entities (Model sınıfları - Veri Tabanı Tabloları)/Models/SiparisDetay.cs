using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KafeOtomasyon.Entities.Models
{
    public class SiparisDetay
    {
        [Key]
        public int SiparisDetayId { get; set; }

        // Sipariş ile ilişki
        public int SiparisId { get; set; }
        [ForeignKey(nameof(SiparisId))]
        public Siparis Siparis { get; set; }

        // Ürün ile ilişki
        public int UrunId { get; set; }
        [ForeignKey(nameof(UrunId))]
        public Urun2 Urun { get; set; }

        // Ürün adedi
        public int Adet { get; set; }

        // Bu ürünün toplam tutarı (adet * ürün fiyatı)
        [Column(TypeName = "decimal(10,2)")]
        public decimal Tutar { get; set; }
    }
}
