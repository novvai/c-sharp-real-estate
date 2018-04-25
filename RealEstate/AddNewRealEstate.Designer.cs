namespace RealEstate
{
    partial class AddNewRealEstate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRealEstate));
            this.closeForm = new System.Windows.Forms.Button();
            this.saveEntry = new System.Windows.Forms.Button();
            this.regionName = new System.Windows.Forms.TextBox();
            this.addressName = new System.Windows.Forms.TextBox();
            this.constructionDate = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(11, 141);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(166, 23);
            this.closeForm.TabIndex = 0;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // saveEntry
            // 
            this.saveEntry.Location = new System.Drawing.Point(186, 141);
            this.saveEntry.Name = "saveEntry";
            this.saveEntry.Size = new System.Drawing.Size(166, 23);
            this.saveEntry.TabIndex = 1;
            this.saveEntry.Text = "Save";
            this.saveEntry.UseVisualStyleBackColor = true;
            this.saveEntry.Click += new System.EventHandler(this.saveEntry_Click);
            // 
            // regionName
            // 
            this.regionName.Location = new System.Drawing.Point(11, 37);
            this.regionName.Name = "regionName";
            this.regionName.Size = new System.Drawing.Size(166, 20);
            this.regionName.TabIndex = 2;
            // 
            // addressName
            // 
            this.addressName.Location = new System.Drawing.Point(186, 37);
            this.addressName.Name = "addressName";
            this.addressName.Size = new System.Drawing.Size(166, 20);
            this.addressName.TabIndex = 3;
            // 
            // constructionDate
            // 
            this.constructionDate.Location = new System.Drawing.Point(186, 76);
            this.constructionDate.Name = "constructionDate";
            this.constructionDate.Size = new System.Drawing.Size(166, 20);
            this.constructionDate.TabIndex = 4;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(11, 115);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(166, 20);
            this.type.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(186, 115);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(166, 20);
            this.price.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Region";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(11, 76);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(166, 20);
            this.area.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Construction Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price";
            // 
            // AddNewRealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 171);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.type);
            this.Controls.Add(this.constructionDate);
            this.Controls.Add(this.addressName);
            this.Controls.Add(this.regionName);
            this.Controls.Add(this.saveEntry);
            this.Controls.Add(this.closeForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewRealEstate";
            this.Text = "AddNewRealEstate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Button saveEntry;
        private System.Windows.Forms.TextBox regionName;
        private System.Windows.Forms.TextBox addressName;
        private System.Windows.Forms.TextBox constructionDate;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}