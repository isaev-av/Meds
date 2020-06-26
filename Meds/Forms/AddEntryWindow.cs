using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Meds.Events;

namespace Meds.Forms
{
    public partial class AddEntryWindow : Form
    {
        public event EventHandler<InsertEntryEventArgs> InsertEntryEvent;

        public AddEntryWindow()
        {
            InitializeComponent();
        }

        private void InsertEntry_Click(object sender, EventArgs e)
        {   
            try
            {
                InsertEntryEvent?.Invoke(this, new InsertEntryEventArgs(
                    drugID.Text,
                    newPharmacyNumber.Text,
                    newDrugName.Text,
                    newAmountOfBatch.Text,
                    newCost.Text,
                    DateTime.Today.ToString("dd/MM/yyyy"),
                    newShelfLife.Text));
                Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelInsert_Click(object sender, EventArgs e) => this.Close();
    }
}
