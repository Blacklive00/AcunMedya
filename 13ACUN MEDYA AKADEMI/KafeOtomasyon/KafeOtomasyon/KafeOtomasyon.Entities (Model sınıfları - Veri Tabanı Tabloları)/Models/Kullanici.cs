using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KafeOtomasyon.Entities.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(100)]
        public string Sifre { get; set; }

        [Required]
        [StringLength(20)]
        public string YetkiTipi { get; set; } = string.Empty;

        // "Admin" veya "Personel"

        // Navigation Property: Bu kullanıcıya ait siparişler
        public ICollection<Siparis> Siparisler { get; set; }
    }
}
