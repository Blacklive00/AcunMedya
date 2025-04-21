using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ACUN_MEDYA_AKADEMI
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Kredi Kartı ile {tutar:N2} TL ödendi.";
        }
    }
}
