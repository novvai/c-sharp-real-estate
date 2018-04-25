using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class AddNewRealEstate : Form
    {
        public List<string> realEstateComponents = new List<string>();
        const string REQUIRED_FIELDS = "All Fields are required!";
        public bool isHandled = false;

        public AddNewRealEstate()
        {
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Validates user input
         * Populate List that will be used for initialisation
         * set its status to handled
         * and trigger event to the parent component
         * 
         * @throw Exception
         */
        private void saveEntry_Click(object sender, EventArgs e)
        {
            List<TextBox> inputData = new List<TextBox> {
                regionName,addressName,area,constructionDate,type,price
            };
            try
            {
                this.ValidateInput(inputData);
                this.HandleData(inputData);
                this.isHandled = true;

                RealEstate parent = (RealEstate)this.Owner;
                parent.handledForm(this);

                this.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;

                MessageBox.Show(msg);
            }
        }

        /**
         * Data Handler that will add every value to the List<object> realEstateComponents
         * further used for class Initialisation and DataGrid visualisation
         */
        private void HandleData(List<TextBox> inputData)
        {
            foreach (TextBox textBox in inputData)
            {
                this.realEstateComponents.Add(textBox.Text);
            }
        }

        /**
         * Boolean Check for empty TextBox
         */
        private bool IsEmpty(TextBox tx)
        {
            return tx.TextLength == 0;
        }

        /**
         * Validates all inputs so there wont be any empty values
         * That will break Class Initialisation
         */
        private void ValidateInput(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (this.IsEmpty(textBox))
                {
                    throw new Exception(REQUIRED_FIELDS);
                }
            }
        }

    }
}
