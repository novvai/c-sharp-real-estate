namespace RealEstate
{
    partial class RealEstate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealEstate));
            this.realEstatesDataView = new System.Windows.Forms.DataGridView();
            this.regionConstraint = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.openNewEntryForm = new System.Windows.Forms.Button();
            this.loadEntries = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.areaConstraint = new System.Windows.Forms.NumericUpDown();
            this.priceConstraint = new System.Windows.Forms.NumericUpDown();
            this.saveEntries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.realEstatesDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaConstraint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceConstraint)).BeginInit();
            this.SuspendLayout();
            // 
            // realEstatesDataView
            // 
            this.realEstatesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realEstatesDataView.Location = new System.Drawing.Point(12, 12);
            this.realEstatesDataView.Name = "realEstatesDataView";
            this.realEstatesDataView.Size = new System.Drawing.Size(776, 318);
            this.realEstatesDataView.TabIndex = 0;
            // 
            // regionConstraint
            // 
            this.regionConstraint.Location = new System.Drawing.Point(282, 352);
            this.regionConstraint.Name = "regionConstraint";
            this.regionConstraint.Size = new System.Drawing.Size(125, 20);
            this.regionConstraint.TabIndex = 1;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(675, 336);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(113, 44);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.Location = new System.Drawing.Point(12, 386);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(776, 199);
            this.searchResults.TabIndex = 5;
            // 
            // openNewEntryForm
            // 
            this.openNewEntryForm.Location = new System.Drawing.Point(12, 336);
            this.openNewEntryForm.Name = "openNewEntryForm";
            this.openNewEntryForm.Size = new System.Drawing.Size(75, 44);
            this.openNewEntryForm.TabIndex = 6;
            this.openNewEntryForm.Text = "New Entry";
            this.openNewEntryForm.UseVisualStyleBackColor = true;
            this.openNewEntryForm.Click += new System.EventHandler(this.openNewEntryForm_Click);
            // 
            // loadEntries
            // 
            this.loadEntries.Location = new System.Drawing.Point(182, 336);
            this.loadEntries.Name = "loadEntries";
            this.loadEntries.Size = new System.Drawing.Size(74, 44);
            this.loadEntries.TabIndex = 7;
            this.loadEntries.Text = "Load Entries";
            this.loadEntries.UseVisualStyleBackColor = true;
            this.loadEntries.Click += new System.EventHandler(this.loadEntries_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search By Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search By Max Price";
            // 
            // areaConstraint
            // 
            this.areaConstraint.DecimalPlaces = 2;
            this.areaConstraint.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.areaConstraint.Location = new System.Drawing.Point(415, 353);
            this.areaConstraint.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.areaConstraint.Name = "areaConstraint";
            this.areaConstraint.Size = new System.Drawing.Size(125, 20);
            this.areaConstraint.TabIndex = 11;
            // 
            // priceConstraint
            // 
            this.priceConstraint.DecimalPlaces = 2;
            this.priceConstraint.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.priceConstraint.Location = new System.Drawing.Point(546, 353);
            this.priceConstraint.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.priceConstraint.Name = "priceConstraint";
            this.priceConstraint.Size = new System.Drawing.Size(125, 20);
            this.priceConstraint.TabIndex = 12;
            // 
            // saveEntries
            // 
            this.saveEntries.Location = new System.Drawing.Point(93, 336);
            this.saveEntries.Name = "saveEntries";
            this.saveEntries.Size = new System.Drawing.Size(83, 44);
            this.saveEntries.TabIndex = 13;
            this.saveEntries.Text = "Save Entries";
            this.saveEntries.UseVisualStyleBackColor = true;
            this.saveEntries.Click += new System.EventHandler(this.saveEntries_Click);
            // 
            // RealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.saveEntries);
            this.Controls.Add(this.priceConstraint);
            this.Controls.Add(this.areaConstraint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadEntries);
            this.Controls.Add(this.openNewEntryForm);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.search);
            this.Controls.Add(this.regionConstraint);
            this.Controls.Add(this.realEstatesDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RealEstate";
            this.Text = "Real Estate";
            this.Load += new System.EventHandler(this.RealEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.realEstatesDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaConstraint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceConstraint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView realEstatesDataView;
        private System.Windows.Forms.TextBox regionConstraint;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListBox searchResults;
        private System.Windows.Forms.Button openNewEntryForm;
        private System.Windows.Forms.Button loadEntries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown areaConstraint;
        private System.Windows.Forms.NumericUpDown priceConstraint;
        private System.Windows.Forms.Button saveEntries;
    }
}

