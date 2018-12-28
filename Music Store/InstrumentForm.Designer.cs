namespace Music_Store
{
    partial class InstrumentForm
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
            this.inquiryLabel = new System.Windows.Forms.Label();
            this.departments = new System.Windows.Forms.ComboBox();
            this.getButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorSelect = new System.Windows.Forms.ComboBox();
            this.maxPrice = new System.Windows.Forms.TrackBar();
            this.colorLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.departmentsLabel = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inquiryLabel
            // 
            this.inquiryLabel.AutoSize = true;
            this.inquiryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inquiryLabel.Location = new System.Drawing.Point(12, 9);
            this.inquiryLabel.Name = "inquiryLabel";
            this.inquiryLabel.Size = new System.Drawing.Size(155, 20);
            this.inquiryLabel.TabIndex = 2;
            this.inquiryLabel.Text = "Instrument Inquiry";
            // 
            // departments
            // 
            this.departments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departments.FormattingEnabled = true;
            this.departments.Items.AddRange(new object[] {
            "All"});
            this.departments.Location = new System.Drawing.Point(193, 32);
            this.departments.Name = "departments";
            this.departments.Size = new System.Drawing.Size(137, 21);
            this.departments.TabIndex = 3;
            this.departments.SelectedIndexChanged += new System.EventHandler(this.departments_SelectedIndexChanged);
            // 
            // getButton
            // 
            this.getButton.Enabled = false;
            this.getButton.Location = new System.Drawing.Point(642, 21);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(97, 32);
            this.getButton.TabIndex = 4;
            this.getButton.Text = "Search";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colorSelect);
            this.groupBox1.Controls.Add(this.maxPrice);
            this.groupBox1.Controls.Add(this.colorLabel);
            this.groupBox1.Controls.Add(this.searchLabel);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Controls.Add(this.departmentsLabel);
            this.groupBox1.Controls.Add(this.departments);
            this.groupBox1.Controls.Add(this.getButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Details";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(580, 13);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(0, 13);
            this.maxLabel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Max Price";
            // 
            // colorSelect
            // 
            this.colorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorSelect.FormattingEnabled = true;
            this.colorSelect.Items.AddRange(new object[] {
            "All"});
            this.colorSelect.Location = new System.Drawing.Point(336, 32);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(137, 21);
            this.colorSelect.TabIndex = 10;
            // 
            // maxPrice
            // 
            this.maxPrice.Location = new System.Drawing.Point(479, 29);
            this.maxPrice.Maximum = 0;
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.RightToLeftLayout = true;
            this.maxPrice.Size = new System.Drawing.Size(157, 45);
            this.maxPrice.SmallChange = 100;
            this.maxPrice.TabIndex = 9;
            this.maxPrice.TickFrequency = 100;
            this.maxPrice.Scroll += new System.EventHandler(this.maxPrice_Scroll);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(333, 13);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "Color";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(7, 16);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(131, 13);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Custom (Make and Model)";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(10, 33);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(177, 20);
            this.searchText.TabIndex = 6;
            // 
            // departmentsLabel
            // 
            this.departmentsLabel.AutoSize = true;
            this.departmentsLabel.Location = new System.Drawing.Point(190, 13);
            this.departmentsLabel.Name = "departmentsLabel";
            this.departmentsLabel.Size = new System.Drawing.Size(62, 13);
            this.departmentsLabel.TabIndex = 5;
            this.departmentsLabel.Text = "Department";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(16, 106);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(745, 338);
            this.dataGrid.TabIndex = 6;
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 457);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inquiryLabel);
            this.Name = "InstrumentForm";
            this.Text = "Music Store";
            this.Load += new System.EventHandler(this.InstrumentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inquiryLabel;
        private System.Windows.Forms.ComboBox departments;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label departmentsLabel;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ComboBox colorSelect;
        private System.Windows.Forms.TrackBar maxPrice;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label1;
    }
}