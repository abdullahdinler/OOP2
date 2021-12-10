using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// :Costemer -> Miras -  Inheritance

namespace OOP2
{
    class LegalCostomer:Costomer // Corporate - Kurumsal
    {
        public string CompanyName { get; set; }  // Sirket adi
        public string TaxNo { get; set; } // vergi numarasi
    }
}
