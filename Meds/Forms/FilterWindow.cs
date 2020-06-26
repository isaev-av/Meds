using System;
using System.Windows.Forms;
using System.Xml.Linq;
using Meds.Events;

namespace Meds.Forms
{
    public partial class FilterWindow : Form
    {
        public event EventHandler<FilterChangeEventArgs> FilterChangeEvent;

        public FilterWindow(XDocument data, FilterChangeEventArgs previousFilterSettings)
        {
            InitializeComponent();
            foreach (XElement drug in data.Element("Medications").Elements("Medication"))
            {
                if (!pharmacyNumberField.Items.Contains(drug.Element("Farmacy_Number").Value))
                {
                    pharmacyNumberField.Items.Add(drug.Element("Farmacy_Number").Value);
                }
            }
            RestoreFilterSettings(previousFilterSettings);
        }

        private void ApplyFilterBtn_Click(object sender, EventArgs e)
        {
            FilterChangeEvent?.Invoke(this, new FilterChangeEventArgs(
                pharmacyNumberField.Enabled && pharmacyNumberField.SelectedItem != null ? pharmacyNumberField.SelectedItem.ToString() : string.Empty,
                DrugNameField.Enabled ? DrugNameField.Text : string.Empty,
                DateOfIncomeField.Enabled ? DateOfIncomeField.Value.ToShortDateString() : string.Empty)
                );
            Close();
        }

        private void CancelFilterChangesBtn_Click(object sender, EventArgs e) => this.Close();
        private void FilterOption_CheckedChanged(object sender, EventArgs e) 
           => Controls[(sender as CheckBox).Name + "Field"].Enabled = (sender as CheckBox).Checked;

        private void RestoreFilterSettings(FilterChangeEventArgs filterArgs)
        {
            if (filterArgs.Farmacy != string.Empty)
            {
                DrugName.Checked = true;
                DrugNameField.Text = filterArgs.Farmacy;
            }
            if (filterArgs.DrugName != string.Empty)
            {
                pharmacyNumber.Checked = true;
                pharmacyNumberField.SelectedItem = filterArgs.DrugName;
            }
            if (filterArgs.DateOfIncome != string.Empty)
            {
                DateOfIncome.Checked = true;
                DateOfIncomeField.Text = filterArgs.DateOfIncome;
            }
        }
    }
}
