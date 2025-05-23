using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class OlayYoneticisi
{
    public static event EventHandler OdemeYapildi;

    public static void OdemeBildir()
    {
        OdemeYapildi?.Invoke(null, EventArgs.Empty);
    }
}
