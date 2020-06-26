using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meds.Events
{
    public class DeleteEntryEventArgs : EventArgs
    {
        public string DrugID { get; set; }

        public DeleteEntryEventArgs(string drugID)
        {
            DrugID = drugID;
        }
    }
}
