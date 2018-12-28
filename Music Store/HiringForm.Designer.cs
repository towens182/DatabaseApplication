namespace Music_Store
{
    partial class HiringForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personalInfoGroup = new System.Windows.Forms.GroupBox();
            this.storeSelect = new System.Windows.Forms.ComboBox();
            this.departmentSelect = new System.Windows.Forms.ComboBox();
            this.jobSelect = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.wageDisplay = new System.Windows.Forms.Label();
            this.wageLabel = new System.Windows.Forms.Label();
            this.storeLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.personalInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(500, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Hiring Center";
            // 
            // personalInfoGroup
            // 
            this.personalInfoGroup.Controls.Add(this.storeSelect);
            this.personalInfoGroup.Controls.Add(this.departmentSelect);
            this.personalInfoGroup.Controls.Add(this.jobSelect);
            this.personalInfoGroup.Controls.Add(this.departmentLabel);
            this.personalInfoGroup.Controls.Add(this.wageDisplay);
            this.personalInfoGroup.Controls.Add(this.wageLabel);
            this.personalInfoGroup.Controls.Add(this.storeLabel);
            this.personalInfoGroup.Controls.Add(this.jobLabel);
            this.personalInfoGroup.Controls.Add(this.label3);
            this.personalInfoGroup.Controls.Add(this.calendar);
            this.personalInfoGroup.Controls.Add(this.dobLabel);
            this.personalInfoGroup.Controls.Add(this.phoneText);
            this.personalInfoGroup.Controls.Add(this.addressText);
            this.personalInfoGroup.Controls.Add(this.phoneLabel);
            this.personalInfoGroup.Controls.Add(this.addressLabel);
            this.personalInfoGroup.Controls.Add(this.label2);
            this.personalInfoGroup.Controls.Add(this.lastNameText);
            this.personalInfoGroup.Controls.Add(this.firstNameLabel);
            this.personalInfoGroup.Controls.Add(this.firstNameText);
            this.personalInfoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoGroup.Location = new System.Drawing.Point(12, 43);
            this.personalInfoGroup.Name = "personalInfoGroup";
            this.personalInfoGroup.Size = new System.Drawing.Size(683, 342);
            this.personalInfoGroup.TabIndex = 1;
            this.personalInfoGroup.TabStop = false;
            this.personalInfoGroup.Text = "Personal Information";
            // 
            // storeSelect
            // 
            this.storeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeSelect.FormattingEnabled = true;
            this.storeSelect.Location = new System.Drawing.Point(488, 285);
            this.storeSelect.Name = "storeSelect";
            this.storeSelect.Size = new System.Drawing.Size(169, 28);
            this.storeSelect.Sorted = true;
            this.storeSelect.TabIndex = 18;
            // 
            // departmentSelect
            // 
            this.departmentSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentSelect.FormattingEnabled = true;
            this.departmentSelect.Location = new System.Drawing.Point(309, 285);
            this.departmentSelect.Name = "departmentSelect";
            this.departmentSelect.Size = new System.Drawing.Size(157, 28);
            this.departmentSelect.Sorted = true;
            this.departmentSelect.TabIndex = 16;
            // 
            // jobSelect
            // 
            this.jobSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobSelect.FormattingEnabled = true;
            this.jobSelect.Location = new System.Drawing.Point(23, 285);
            this.jobSelect.Name = "jobSelect";
            this.jobSelect.Size = new System.Drawing.Size(164, 28);
            this.jobSelect.Sorted = true;
            this.jobSelect.TabIndex = 12;
            this.jobSelect.SelectedIndexChanged += new System.EventHandler(this.jobSelect_SelectedIndexChanged);
            // 
            // departmentLabel
            // 
            this.departmentLabel.Location = new System.Drawing.Point(309, 249);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(109, 20);
            this.departmentLabel.TabIndex = 15;
            this.departmentLabel.Text = "Department";
            // 
            // wageDisplay
            // 
            this.wageDisplay.AutoSize = true;
            this.wageDisplay.Location = new System.Drawing.Point(210, 288);
            this.wageDisplay.Name = "wageDisplay";
            this.wageDisplay.Size = new System.Drawing.Size(0, 20);
            this.wageDisplay.TabIndex = 14;
            // 
            // wageLabel
            // 
            this.wageLabel.AutoSize = true;
            this.wageLabel.Location = new System.Drawing.Point(210, 249);
            this.wageLabel.Name = "wageLabel";
            this.wageLabel.Size = new System.Drawing.Size(51, 20);
            this.wageLabel.TabIndex = 13;
            this.wageLabel.Text = "Wage";
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Location = new System.Drawing.Point(484, 249);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(48, 20);
            this.storeLabel.TabIndex = 17;
            this.storeLabel.Text = "Store";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(19, 249);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(68, 20);
            this.jobLabel.TabIndex = 11;
            this.jobLabel.Text = "Job Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Ex: 555-1234)";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(430, 68);
            this.calendar.MaxDate = new System.DateTime(2020, 12, 31, 15, 58, 0, 0);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.ShowToday = false;
            this.calendar.TabIndex = 10;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(426, 39);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(99, 20);
            this.dobLabel.TabIndex = 9;
            this.dobLabel.Text = "Date of Birth";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(234, 180);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(184, 26);
            this.phoneText.TabIndex = 8;
            this.phoneText.TextChanged += new System.EventHandler(this.phoneText_TextChanged);
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(234, 79);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(184, 26);
            this.addressText.TabIndex = 3;
            this.addressText.TextChanged += new System.EventHandler(this.addressText_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(230, 139);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(230, 39);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(23, 180);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(164, 26);
            this.lastNameText.TabIndex = 5;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(19, 39);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(23, 79);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(164, 26);
            this.firstNameText.TabIndex = 1;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // HiringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 460);
            this.Controls.Add(this.personalInfoGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "HiringForm";
            this.Text = "Music Store";
            this.Load += new System.EventHandler(this.HiringForm_Load);
            this.personalInfoGroup.ResumeLayout(false);
            this.personalInfoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox personalInfoGroup;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wageLabel;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label wageDisplay;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ComboBox storeSelect;
        private System.Windows.Forms.ComboBox departmentSelect;
        private System.Windows.Forms.ComboBox jobSelect;
        private System.Windows.Forms.MonthCalendar calendar;
    }
}

