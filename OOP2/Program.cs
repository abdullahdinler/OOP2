using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
             RealCostomer realCostomer = new RealCostomer();
            realCostomer.Id = 1;
            realCostomer.CostomerFirstName = "Abdullah";
            realCostomer.CostomerLastName = "Dinler";
            realCostomer.CostomerNo = "54734843854";
            realCostomer.CostomerTcNo = "4683826789436";

            LegalCostomer legalCostomer = new LegalCostomer();
            legalCostomer.Id = 3;
            legalCostomer.CostomerNo = "54784358487";
            legalCostomer.CompanyName = "Merdin Softfare";
            legalCostomer.TaxNo = "4683638485";

            Costomer costomer1 = new RealCostomer();      // Burada costomer1 realCostemerdeki ozelikleri almasini sagladik
            Costomer costomer2 = new LegalCostomer();



            CostomerManager costomerManager = new CostomerManager();
            costomerManager.Add(costomer1);    // Musteri 1 ve musteri ikiyi sisteme ekledik.
            costomerManager.Add(costomer2);

        }
    }
}
