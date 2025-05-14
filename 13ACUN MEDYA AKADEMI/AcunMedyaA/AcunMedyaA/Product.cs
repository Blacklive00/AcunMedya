using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaA
{

    /// <summary>
    /// attribute class 
    /// </summary>
    [Serializable]
    public class Product
    {
            public string Name { get; set; }
        public DateTime expireDate { get; set; }

        public string price { get; set; }



    }
}
