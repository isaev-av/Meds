using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meds.Events
{
    public class InsertEntryEventArgs : EventArgs
    {
        public string DrugID { get;  set; }
        public string PharmacyNumber { get;  set; }
        public string DrugName { get;  set; }
        public string AmountOfBatch { get;  set; }
        public string Cost { get;  set; }
        public string DateOfIncome { get;  set; }
        public string ShelfLife { get;  set; }

        public InsertEntryEventArgs(string drugID, string pharmacyNumber, string drugName, string amountOfBatch, string cost, string dateOfIncome, string shelfLife)
        {
            DrugID = drugID;
            PharmacyNumber = pharmacyNumber;
            DrugName = drugName;
            AmountOfBatch = amountOfBatch;
            Cost = cost;
            DateOfIncome = dateOfIncome;
            ShelfLife = shelfLife;
        }
    }
}
