using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class GerekliAlanAttribute : Attribute
{
    public string HataMesaji { get; }

    public GerekliAlanAttribute(string hataMesaji)
    {
        HataMesaji = hataMesaji;
    }
}
