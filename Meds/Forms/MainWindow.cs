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
using Meds.Forms;


namespace Meds
{
    public partial class MainWindow : Form
    {
        private const string DBFileName = "MedsBase.xml";
        private FilterChangeEventArgs _currentFilterArgs;
        private XDocument _data;
        private List<string> _filteredDrugs;

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                LoadData();
                ClearFilter();
                printMeds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(-1);
            }

        }

        private void SetFilterBtn_Click(object sender, EventArgs args)
        {
            var filterWindow = new FilterWindow(_data, _currentFilterArgs);
            filterWindow.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnFilterChange);
            filterWindow.ShowDialog();
        }

        private void InsertBtn_Click(object sender, EventArgs args)
        {
            var addEntryWindow = new AddEntryWindow();
            addEntryWindow.InsertEntryEvent += new EventHandler<InsertEntryEventArgs>(this.OnInsertEntry);
            addEntryWindow.ShowDialog();
        }

        private void OnFilterChange(object sender, FilterChangeEventArgs args)
        {
            _currentFilterArgs = args;
            DoFilter();
            printMeds();
        }

        private void OnInsertEntry(object sender, InsertEntryEventArgs args)
        {
            if (args.PharmacyNumber == string.Empty || args.DrugName == string.Empty || args.AmountOfBatch == string.Empty || args.Cost == string.Empty || args.ShelfLife == string.Empty)
            {
                throw new ArgumentException("Please fill all of the fields.");
            }
            foreach (XElement drug in _data.Element("Medications").Elements("Medication"))
            {
                if (drug.Element("DrugID").Value == args.DrugID) throw new ArgumentException(
                    "Medication with that ID already exists.");
            }

            _data.Element("Medications").Add(new XElement("Medication",
                new XElement("DrugID", args.DrugID),
                new XElement("Farmacy_Number", args.PharmacyNumber),
                new XElement("Drug_Name", args.DrugName),
                new XElement("AmountOfBatch", args.AmountOfBatch),
                new XElement("Cost", args.Cost),
                new XElement("Date_Of_Income", args.DateOfIncome),
                new XElement("Shelf_Life", args.ShelfLife)));

            if (!(_currentFilterArgs is null))
            {
                DoFilter();
            }
            printMeds();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var deleteEntryWindow = new DeleteEntryWindow();
            deleteEntryWindow.deleteEntryEvent += new EventHandler<DeleteEntryEventArgs>(OnDeleteEntry);
            deleteEntryWindow.ShowDialog();
        }

        private void OnDeleteEntry(object sender, DeleteEntryEventArgs e)
        {
            foreach (XElement drug in _data.Element("Medications").Elements("Medication"))
            {
                if (drug.Element("DrugID").Value == e.DrugID)
                {
                    drug.Remove();
                    DoFilter();
                    printMeds();
                    return;
                }
            }
            throw new ArgumentException($"Medicine with id ${e.DrugID} not found");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFilter();
            printMeds();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _data.Save(DBFileName);
                MessageBox.Show("Saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CancelChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                DoFilter();
                printMeds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData() => _data = XDocument.Load(DBFileName);

        private void ClearFilter()
        {
            _currentFilterArgs = new FilterChangeEventArgs();
            DoFilter();
        }

        private void printMeds()
        {
            StringBuilder sb = new StringBuilder();
            foreach (XElement drug in from drug in _data.Element("Medications").Elements("Medication") where _filteredDrugs.Contains(drug.Element("DrugID").Value) select drug)
            {
                foreach (XElement dataField in drug.Elements())
                {
                    sb.Append($"{dataField.Name.ToString().Replace('_', ' ')}: {dataField.Value}\r\n");
                }
                sb.Append("\r\n");
            }
            tableView.Text = sb.ToString();
        }

        private void DoFilter()
        {
            try
            {
                _filteredDrugs = (from person in _data.Element("Medications").Elements("Medication")
                                  where person.Element("Farmacy_Number").Value.ToLower().Contains(_currentFilterArgs.Farmacy.ToLower())
                                   && person.Element("Drug_Name").Value.Contains(_currentFilterArgs.DrugName)
                                  select person.Element("DrugID").Value).ToList();
            }
            catch (NullReferenceException)
            {
                throw new FormatException("Incorrect inputed filter data");
            }
        }
    }
}
