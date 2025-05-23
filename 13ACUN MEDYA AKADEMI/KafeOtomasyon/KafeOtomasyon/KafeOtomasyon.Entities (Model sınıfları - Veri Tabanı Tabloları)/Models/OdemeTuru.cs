using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KafeOtomasyon.Entities.Models
{
    public class OdemeTuru
    {
        [Key]
        public int OdemeTuruId { get; set; }

        [Required]
        [StringLength(20)]
        public string Turu { get; set; }  // Örneğin: "Nakit", "Kart", "QR Kod"

        public ICollection<Siparis> Siparisler { get; set; }

        public OdemeTuru()
        {
            Siparisler = new List<Siparis>();
        }
    }
}
