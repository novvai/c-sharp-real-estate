using RealEstate.Interfaces;
using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class RealEstate : Form
    {
        private List<RealEstateInterface> realEstates = new List<RealEstateInterface>();
        private DataTable table = new DataTable();

        private const string FILE_DEFAULT_EXTENSION = "txt";
        private const string FILE_FILTER = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

        public RealEstate()
        {
            InitializeComponent();
        }
        
        /**
         * Open new form view to read all information about the real Eastate;
         */
        private void openNewEntryForm_Click(object sender, EventArgs e)
        {
            AddNewRealEstate realEstateFrom = new AddNewRealEstate();
            realEstateFrom.Show(this);
        }
        
        /**
         * Self made event Handler
         * It is called from the child component
         * giving all needed information about the real estate class
         */
        public void handledForm(AddNewRealEstate realEstateFrom)
        {
            if (realEstateFrom.isHandled)
            {
                RealEstateInterface buffer = new RealEstateModel(realEstateFrom.realEstateComponents);
                this.addInternalStorage(buffer);
                this.addToDataGrid(buffer);
            }
        }

        /**
         * Add entry to the Internal List for further computation
         */
        private void addInternalStorage(RealEstateInterface realEstate)
        {
            this.realEstates.Add(realEstate);
        }

        /**
         * Add entry to the DataGrid
         * Visualisation of the Real Estate Data
         */
        private void addToDataGrid(RealEstateInterface realEstate)
        {
            this.table.Rows.Add(realEstate.GetInfoAsArray());
        }

        /**
         * Basic Loader - Setting up the Data Grid View
         */
        private void RealEstate_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Region", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Area", typeof(string));
            table.Columns.Add("Construction Date", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Price", typeof(string));


            realEstatesDataView.DataSource = table;
        }
        /**
         * Clear the ListBox
         * Adds new found entries that satisfy given constraints
         */
        private void search_Click(object sender, EventArgs e)
        {
            var result = realEstates.Where(this.QueryBuilder).ToList();
            searchResults.Items.Clear();
            foreach (RealEstateInterface estate in result)
            {
                searchResults.Items.Add(estate.getInfoAsString());
            }
        }

        /**
         * Predefined query with the given argument;
         * TODO - Make another class that will manage all possible queries by chaining statements
         */
        private bool QueryBuilder(RealEstateInterface arg)
        {
            double.TryParse(areaConstraint.Value.ToString(), out double areaConst);
            decimal maxPrice = priceConstraint.Value;
            string region = regionConstraint.Text;
            bool flag = true;

            if(areaConst > 0 && arg.getArea() > areaConst)
            {
                flag = false;
            }

            if (maxPrice > 0 && arg.getPrice() > maxPrice)
            {
                flag = false;
            }

            if (region.Length > 0 && !arg.getRegion().Contains(region))
            {
                flag = false;
            }

            return flag;
        }


        /**
        * Save entries to user specified txt file with right the structer
        */
        private void saveEntries_Click(object sender, EventArgs e)
        {
            SaveFileDialog entriesFileLoc = new SaveFileDialog();
            
            entriesFileLoc.DefaultExt = FILE_DEFAULT_EXTENSION;
            entriesFileLoc.Filter = FILE_FILTER;

            if (entriesFileLoc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (TextWriter writer = File.CreateText(entriesFileLoc.FileName))
                {
                    foreach (RealEstateInterface estate in this.realEstates)
                    {
                        writer.WriteLine(estate.getInfoAsString());
                    }
                }
            }
        }
        
        /**
         * Load entries from given txt file with right structer
         */
        private void loadEntries_Click(object sender, EventArgs e)
        {
            string line;
            OpenFileDialog entriesFileOpen = new OpenFileDialog();

            entriesFileOpen.DefaultExt = FILE_DEFAULT_EXTENSION;
            entriesFileOpen.Filter = FILE_FILTER;

            if (entriesFileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader file = new StreamReader(entriesFileOpen.FileName);

                while ((line = file.ReadLine()) != null)
                {
                    List<string> realEstateParameters = line.Split('\t').ToList();
                    RealEstateInterface buffer = new RealEstateModel(realEstateParameters);
                    this.addInternalStorage(buffer);
                    this.addToDataGrid(buffer);
                }

                file.Close();
            }
        }
    }
}
