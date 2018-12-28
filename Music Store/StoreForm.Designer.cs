namespace Music_Store
{
    partial class StoreForm
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
            this.storeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.avgTenureLabel = new System.Windows.Forms.Label();
            this.avgWageLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numEmployeeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.storeIdLabel = new System.Windows.Forms.Label();
            this.salesGB = new System.Windows.Forms.GroupBox();
            this.expensiveItemLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numSalesLabel = new System.Windows.Forms.Label();
            this.topEmpLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.salesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeSelect
            // 
            this.storeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeSelect.FormattingEnabled = true;
            this.storeSelect.Location = new System.Drawing.Point(6, 19);
            this.storeSelect.Name = "storeSelect";
            this.storeSelect.Size = new System.Drawing.Size(169, 28);
            this.storeSelect.Sorted = true;
            this.storeSelect.TabIndex = 19;
            this.storeSelect.SelectedIndexChanged += new System.EventHandler(this.storeSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select a store to view performance...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.avgTenureLabel);
            this.groupBox1.Controls.Add(this.avgWageLabel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numEmployeeLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.phoneLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.managerLabel);
            this.groupBox1.Controls.Add(this.locationLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 151);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Details";
            // 
            // avgTenureLabel
            // 
            this.avgTenureLabel.AutoSize = true;
            this.avgTenureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgTenureLabel.Location = new System.Drawing.Point(250, 115);
            this.avgTenureLabel.Name = "avgTenureLabel";
            this.avgTenureLabel.Size = new System.Drawing.Size(0, 20);
            this.avgTenureLabel.TabIndex = 13;
            // 
            // avgWageLabel
            // 
            this.avgWageLabel.AutoSize = true;
            this.avgWageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgWageLabel.Location = new System.Drawing.Point(417, 115);
            this.avgWageLabel.Name = "avgWageLabel";
            this.avgWageLabel.Size = new System.Drawing.Size(0, 20);
            this.avgWageLabel.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Average Wage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Average Tenure";
            // 
            // numEmployeeLabel
            // 
            this.numEmployeeLabel.AutoSize = true;
            this.numEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEmployeeLabel.Location = new System.Drawing.Point(69, 115);
            this.numEmployeeLabel.Name = "numEmployeeLabel";
            this.numEmployeeLabel.Size = new System.Drawing.Size(0, 20);
            this.numEmployeeLabel.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Number of Employees";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(250, 57);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(0, 20);
            this.phoneLabel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Manager";
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLabel.Location = new System.Drawing.Point(415, 57);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(0, 20);
            this.managerLabel.TabIndex = 4;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(17, 57);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 20);
            this.locationLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.storeSelect);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 57);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Store";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(532, 21);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(77, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Store ID";
            // 
            // storeIdLabel
            // 
            this.storeIdLabel.AutoSize = true;
            this.storeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeIdLabel.Location = new System.Drawing.Point(562, 43);
            this.storeIdLabel.Name = "storeIdLabel";
            this.storeIdLabel.Size = new System.Drawing.Size(0, 20);
            this.storeIdLabel.TabIndex = 1;
            // 
            // salesGB
            // 
            this.salesGB.Controls.Add(this.expensiveItemLabel);
            this.salesGB.Controls.Add(this.label13);
            this.salesGB.Controls.Add(this.numSalesLabel);
            this.salesGB.Controls.Add(this.topEmpLabel);
            this.salesGB.Controls.Add(this.label4);
            this.salesGB.Controls.Add(this.label21);
            this.salesGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesGB.Location = new System.Drawing.Point(12, 223);
            this.salesGB.Name = "salesGB";
            this.salesGB.Size = new System.Drawing.Size(610, 91);
            this.salesGB.TabIndex = 22;
            this.salesGB.TabStop = false;
            this.salesGB.Text = "Sales Details";
            // 
            // expensiveItemLabel
            // 
            this.expensiveItemLabel.AutoSize = true;
            this.expensiveItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensiveItemLabel.Location = new System.Drawing.Point(381, 56);
            this.expensiveItemLabel.Name = "expensiveItemLabel";
            this.expensiveItemLabel.Size = new System.Drawing.Size(0, 20);
            this.expensiveItemLabel.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Most Expensive Item Sold";
            // 
            // numSalesLabel
            // 
            this.numSalesLabel.AutoSize = true;
            this.numSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSalesLabel.Location = new System.Drawing.Point(274, 52);
            this.numSalesLabel.Name = "numSalesLabel";
            this.numSalesLabel.Size = new System.Drawing.Size(0, 20);
            this.numSalesLabel.TabIndex = 15;
            // 
            // topEmpLabel
            // 
            this.topEmpLabel.AutoSize = true;
            this.topEmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topEmpLabel.Location = new System.Drawing.Point(27, 56);
            this.topEmpLabel.Name = "topEmpLabel";
            this.topEmpLabel.Size = new System.Drawing.Size(0, 20);
            this.topEmpLabel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "# of Sales";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Top Employee";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 328);
            this.Controls.Add(this.salesGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.storeIdLabel);
            this.Name = "StoreForm";
            this.Text = "Store";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.salesGB.ResumeLayout(false);
            this.salesGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox storeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label avgTenureLabel;
        private System.Windows.Forms.Label avgWageLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label numEmployeeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label storeIdLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.GroupBox salesGB;
        private System.Windows.Forms.Label topEmpLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label expensiveItemLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label numSalesLabel;
        private System.Windows.Forms.Label label4;
    }
}