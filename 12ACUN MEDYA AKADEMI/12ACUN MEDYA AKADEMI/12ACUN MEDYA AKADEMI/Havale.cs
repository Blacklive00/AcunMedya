using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ACUN_MEDYA_AKADEMI
{
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Havale ile {tutar:N2} TL ödendi.";
        }
    }
}
