namespace Meds.Forms
{
    partial class AddEntryWindow
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label10;
            this.drugID = new System.Windows.Forms.TextBox();
            this.newShelfLife = new System.Windows.Forms.TextBox();
            this.newDrugName = new System.Windows.Forms.TextBox();
            this.newPharmacyNumber = new System.Windows.Forms.TextBox();
            this.newAmountOfBatch = new System.Windows.Forms.ComboBox();
            this.cancelInsert = new System.Windows.Forms.Button();
            this.insertEntry = new System.Windows.Forms.Button();
            this.newCost = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(18, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Drug ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(95, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 24);
            label2.TabIndex = 1;
            label2.Text = "Create New";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(18, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 17);
            label3.TabIndex = 2;
            label3.Text = "Pharmacy Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(18, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 17);
            label4.TabIndex = 3;
            label4.Text = "Drug Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(18, 147);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(115, 17);
            label5.TabIndex = 4;
            label5.Text = "Amount Of Batch";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.Location = new System.Drawing.Point(18, 205);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(67, 17);
            label7.TabIndex = 6;
            label7.Text = "Shelf Life";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.Location = new System.Drawing.Point(18, 174);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(36, 17);
            label10.TabIndex = 27;
            label10.Text = "Cost";
            // 
            // drugID
            // 
            this.drugID.Location = new System.Drawing.Point(163, 60);
            this.drugID.Name = "drugID";
            this.drugID.Size = new System.Drawing.Size(122, 20);
            this.drugID.TabIndex = 0;
            // 
            // newShelfLife
            // 
            this.newShelfLife.Location = new System.Drawing.Point(163, 202);
            this.newShelfLife.Name = "newShelfLife";
            this.newShelfLife.Size = new System.Drawing.Size(122, 20);
            this.newShelfLife.TabIndex = 6;
            // 
            // newDrugName
            // 
            this.newDrugName.Location = new System.Drawing.Point(163, 116);
            this.newDrugName.Name = "newDrugName";
            this.newDrugName.Size = new System.Drawing.Size(122, 20);
            this.newDrugName.TabIndex = 2;
            // 
            // newPharmacyNumber
            // 
            this.newPharmacyNumber.Location = new System.Drawing.Point(163, 88);
            this.newPharmacyNumber.Name = "newPharmacyNumber";
            this.newPharmacyNumber.Size = new System.Drawing.Size(122, 20);
            this.newPharmacyNumber.TabIndex = 1;
            // 
            // newAmountOfBatch
            // 
            this.newAmountOfBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.newAmountOfBatch.FormattingEnabled = true;
            this.newAmountOfBatch.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.newAmountOfBatch.Location = new System.Drawing.Point(163, 144);
            this.newAmountOfBatch.Name = "newAmountOfBatch";
            this.newAmountOfBatch.Size = new System.Drawing.Size(122, 21);
            this.newAmountOfBatch.TabIndex = 3;
            // 
            // cancelInsert
            // 
            this.cancelInsert.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelInsert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelInsert.Location = new System.Drawing.Point(163, 246);
            this.cancelInsert.Name = "cancelInsert";
            this.cancelInsert.Size = new System.Drawing.Size(123, 30);
            this.cancelInsert.TabIndex = 13;
            this.cancelInsert.Text = "Cancel";
            this.cancelInsert.UseVisualStyleBackColor = false;
            this.cancelInsert.Click += new System.EventHandler(this.CancelInsert_Click);
            // 
            // insertEntry
            // 
            this.insertEntry.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.insertEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertEntry.Location = new System.Drawing.Point(21, 246);
            this.insertEntry.Name = "insertEntry";
            this.insertEntry.Size = new System.Drawing.Size(123, 30);
            this.insertEntry.TabIndex = 12;
            this.insertEntry.Text = "Create";
            this.insertEntry.UseVisualStyleBackColor = false;
            this.insertEntry.Click += new System.EventHandler(this.InsertEntry_Click);
            // 
            // newCost
            // 
            this.newCost.Location = new System.Drawing.Point(163, 173);
            this.newCost.Name = "newCost";
            this.newCost.Size = new System.Drawing.Size(122, 20);
            this.newCost.TabIndex = 4;
            // 
            // AddEntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(303, 297);
            this.Controls.Add(this.newCost);
            this.Controls.Add(label10);
            this.Controls.Add(this.cancelInsert);
            this.Controls.Add(this.insertEntry);
            this.Controls.Add(this.newAmountOfBatch);
            this.Controls.Add(this.newPharmacyNumber);
            this.Controls.Add(this.newDrugName);
            this.Controls.Add(this.newShelfLife);
            this.Controls.Add(this.drugID);
            this.Controls.Add(label7);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEntryWindow";
            this.Text = "Add Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox drugID;
        private System.Windows.Forms.TextBox newShelfLife;
        private System.Windows.Forms.TextBox newDrugName;
        private System.Windows.Forms.TextBox newPharmacyNumber;
        private System.Windows.Forms.ComboBox newAmountOfBatch;
        private System.Windows.Forms.Button cancelInsert;
        private System.Windows.Forms.Button insertEntry;
        private System.Windows.Forms.TextBox newCost;
    }
}