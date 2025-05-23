using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KafeOtomasyon.Entities.Models
{
    public class UrunGrup
    {
        [Key]
        public int UrunGrupId { get; set; }

        [Required]
        [StringLength(50)]
        public string GrupAdi { get; set; }  // Örn: "İçecekler", "Tatlılar"

        // Navigation: Bu gruba ait ürünler
        public ICollection<Urun2> Urunler { get; set; }
    }
}
