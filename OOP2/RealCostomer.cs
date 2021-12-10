using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// :Costemer -> Miras -  Inheritance

namespace OOP2
{
    class RealCostomer:Costomer // Individual - Bireysel
    {
        public int Id { get; set; } // Musteri id
        public string CostomerNo { get; set; } // Musteri no
        public string CostomerTcNo { get; set; } // Musteri TC no
        public string CostomerFirstName { get; set; }  // Musteri adi
        public string CostomerLastName { get; set; } //  Musteri Soyadi
    }
}
