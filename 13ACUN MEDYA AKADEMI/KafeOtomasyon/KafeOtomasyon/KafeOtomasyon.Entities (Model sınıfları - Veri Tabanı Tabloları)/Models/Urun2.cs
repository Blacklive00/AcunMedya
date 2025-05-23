using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KafeOtomasyon.Entities.Models
{
    public class Urun2
    {
        [Key]
        public int UrunId { get; set; }

        [Required]
        [StringLength(100)]
        public string UrunAdi { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Fiyat { get; set; }

        // FK to UrunGrup
        public int UrunGrupId { get; set; }
        [ForeignKey(nameof(UrunGrupId))]

        // Yeni eklenmeli:
        public int StokAdedi { get; set; }

        // Navigation property
        public UrunGrup UrunGrup { get; set; }

        // Navigation: Bu ürün, sipariş detaylarında yer alabilir
        public ICollection<SiparisDetay> SiparisDetaylari { get; set; }
    }
}
