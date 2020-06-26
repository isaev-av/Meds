using System;

namespace Meds.Events
{
    public class FilterChangeEventArgs : EventArgs
    {
        public string Farmacy { get;  set; }
        public string DrugName { get;  set; }
        public string DateOfIncome { get;  set; }

        public FilterChangeEventArgs(string farmacy, string drugName, string dateOfIncome)
        {
            Farmacy = farmacy;
            DrugName = drugName;
            DateOfIncome = dateOfIncome;
        }

        public FilterChangeEventArgs()
        {
            Farmacy = string.Empty;
            DrugName = string.Empty;
            DateOfIncome = string.Empty;
        }
    }
}
