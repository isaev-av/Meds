namespace Meds.Forms
{
    partial class FilterWindow
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
            this.DrugNameField = new System.Windows.Forms.TextBox();
            this.DateOfIncomeField = new System.Windows.Forms.DateTimePicker();
            this.pharmacyNumberField = new System.Windows.Forms.ComboBox();
            this.applyFilterBtn = new System.Windows.Forms.Button();
            this.cancelFilterChangesBtn = new System.Windows.Forms.Button();
            this.pharmacyNumber = new System.Windows.Forms.CheckBox();
            this.DrugName = new System.Windows.Forms.CheckBox();
            this.DateOfIncome = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DrugNameField
            // 
            this.DrugNameField.Enabled = false;
            this.DrugNameField.Location = new System.Drawing.Point(169, 51);
            this.DrugNameField.Name = "DrugNameField";
            this.DrugNameField.Size = new System.Drawing.Size(150, 20);
            this.DrugNameField.TabIndex = 0;
            // 
            // DateOfIncomeField
            // 
            this.DateOfIncomeField.Enabled = false;
            this.DateOfIncomeField.Location = new System.Drawing.Point(169, 89);
            this.DateOfIncomeField.Name = "DateOfIncomeField";
            this.DateOfIncomeField.Size = new System.Drawing.Size(150, 20);
            this.DateOfIncomeField.TabIndex = 5;
            this.DateOfIncomeField.Value = new System.DateTime(2020, 6, 26, 13, 25, 45, 0);
            // 
            // pharmacyNumberField
            // 
            this.pharmacyNumberField.Enabled = false;
            this.pharmacyNumberField.FormattingEnabled = true;
            this.pharmacyNumberField.Location = new System.Drawing.Point(169, 16);
            this.pharmacyNumberField.Name = "pharmacyNumberField";
            this.pharmacyNumberField.Size = new System.Drawing.Size(150, 21);
            this.pharmacyNumberField.TabIndex = 6;
            // 
            // applyFilterBtn
            // 
            this.applyFilterBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.applyFilterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.applyFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyFilterBtn.Location = new System.Drawing.Point(12, 129);
            this.applyFilterBtn.Name = "applyFilterBtn";
            this.applyFilterBtn.Size = new System.Drawing.Size(123, 30);
            this.applyFilterBtn.TabIndex = 7;
            this.applyFilterBtn.Text = "Apply";
            this.applyFilterBtn.UseVisualStyleBackColor = false;
            this.applyFilterBtn.Click += new System.EventHandler(this.ApplyFilterBtn_Click);
            // 
            // cancelFilterChangesBtn
            // 
            this.cancelFilterChangesBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelFilterChangesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelFilterChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelFilterChangesBtn.Location = new System.Drawing.Point(196, 129);
            this.cancelFilterChangesBtn.Name = "cancelFilterChangesBtn";
            this.cancelFilterChangesBtn.Size = new System.Drawing.Size(123, 30);
            this.cancelFilterChangesBtn.TabIndex = 8;
            this.cancelFilterChangesBtn.Text = "Cancel";
            this.cancelFilterChangesBtn.UseVisualStyleBackColor = false;
            this.cancelFilterChangesBtn.Click += new System.EventHandler(this.CancelFilterChangesBtn_Click);
            // 
            // pharmacyNumber
            // 
            this.pharmacyNumber.AutoSize = true;
            this.pharmacyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pharmacyNumber.Location = new System.Drawing.Point(18, 16);
            this.pharmacyNumber.Name = "pharmacyNumber";
            this.pharmacyNumber.Size = new System.Drawing.Size(108, 21);
            this.pharmacyNumber.TabIndex = 11;
            this.pharmacyNumber.Text = "Pharmacy №";
            this.pharmacyNumber.UseVisualStyleBackColor = true;
            this.pharmacyNumber.CheckedChanged += new System.EventHandler(this.FilterOption_CheckedChanged);
            // 
            // DrugName
            // 
            this.DrugName.AutoSize = true;
            this.DrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrugName.Location = new System.Drawing.Point(18, 51);
            this.DrugName.Name = "DrugName";
            this.DrugName.Size = new System.Drawing.Size(99, 21);
            this.DrugName.TabIndex = 12;
            this.DrugName.Text = "Drug Name";
            this.DrugName.UseVisualStyleBackColor = true;
            this.DrugName.CheckedChanged += new System.EventHandler(this.FilterOption_CheckedChanged);
            // 
            // DateOfIncome
            // 
            this.DateOfIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfIncome.Location = new System.Drawing.Point(18, 88);
            this.DateOfIncome.Name = "DateOfIncome";
            this.DateOfIncome.Size = new System.Drawing.Size(130, 21);
            this.DateOfIncome.TabIndex = 14;
            this.DateOfIncome.Text = "Date Of Income";
            this.DateOfIncome.UseVisualStyleBackColor = true;
            this.DateOfIncome.CheckedChanged += new System.EventHandler(this.FilterOption_CheckedChanged);
            // 
            // FilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(337, 176);
            this.Controls.Add(this.DateOfIncome);
            this.Controls.Add(this.DrugName);
            this.Controls.Add(this.pharmacyNumber);
            this.Controls.Add(this.cancelFilterChangesBtn);
            this.Controls.Add(this.applyFilterBtn);
            this.Controls.Add(this.pharmacyNumberField);
            this.Controls.Add(this.DateOfIncomeField);
            this.Controls.Add(this.DrugNameField);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DrugNameField;
        private System.Windows.Forms.DateTimePicker DateOfIncomeField;
        private System.Windows.Forms.ComboBox pharmacyNumberField;
        private System.Windows.Forms.Button applyFilterBtn;
        private System.Windows.Forms.Button cancelFilterChangesBtn;
        private System.Windows.Forms.CheckBox pharmacyNumber;
        private System.Windows.Forms.CheckBox DrugName;
        private System.Windows.Forms.CheckBox DateOfIncome;
    }
}