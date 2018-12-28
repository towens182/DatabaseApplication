namespace Music_Store
{
    partial class EditEmployee
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
            this.personalInfoGroup = new System.Windows.Forms.GroupBox();
            this.dobText = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.hireDateText = new System.Windows.Forms.TextBox();
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.wageText = new System.Windows.Forms.TextBox();
            this.storeSelect = new System.Windows.Forms.ComboBox();
            this.departmentSelect = new System.Windows.Forms.ComboBox();
            this.jobSelect = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.wageDisplay = new System.Windows.Forms.Label();
            this.wageLabel = new System.Windows.Forms.Label();
            this.storeLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.personalInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalInfoGroup
            // 
            this.personalInfoGroup.Controls.Add(this.dobText);
            this.personalInfoGroup.Controls.Add(this.dobLabel);
            this.personalInfoGroup.Controls.Add(this.hireDateText);
            this.personalInfoGroup.Controls.Add(this.hireDateLabel);
            this.personalInfoGroup.Controls.Add(this.wageText);
            this.personalInfoGroup.Controls.Add(this.storeSelect);
            this.personalInfoGroup.Controls.Add(this.departmentSelect);
            this.personalInfoGroup.Controls.Add(this.jobSelect);
            this.personalInfoGroup.Controls.Add(this.departmentLabel);
            this.personalInfoGroup.Controls.Add(this.wageDisplay);
            this.personalInfoGroup.Controls.Add(this.wageLabel);
            this.personalInfoGroup.Controls.Add(this.storeLabel);
            this.personalInfoGroup.Controls.Add(this.jobLabel);
            this.personalInfoGroup.Controls.Add(this.phoneText);
            this.personalInfoGroup.Controls.Add(this.addressText);
            this.personalInfoGroup.Controls.Add(this.phoneLabel);
            this.personalInfoGroup.Controls.Add(this.addressLabel);
            this.personalInfoGroup.Controls.Add(this.label2);
            this.personalInfoGroup.Controls.Add(this.lastNameText);
            this.personalInfoGroup.Controls.Add(this.firstNameLabel);
            this.personalInfoGroup.Controls.Add(this.firstNameText);
            this.personalInfoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.personalInfoGroup.Name = "personalInfoGroup";
            this.personalInfoGroup.Size = new System.Drawing.Size(408, 319);
            this.personalInfoGroup.TabIndex = 0;
            this.personalInfoGroup.TabStop = false;
            this.personalInfoGroup.Text = "Personal Information";
            // 
            // dobText
            // 
            this.dobText.Enabled = false;
            this.dobText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobText.Location = new System.Drawing.Point(23, 166);
            this.dobText.Name = "dobText";
            this.dobText.Size = new System.Drawing.Size(184, 26);
            this.dobText.TabIndex = 4;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(19, 143);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(99, 20);
            this.dobLabel.TabIndex = 24;
            this.dobLabel.Text = "Date of Birth";
            // 
            // hireDateText
            // 
            this.hireDateText.Enabled = false;
            this.hireDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireDateText.Location = new System.Drawing.Point(214, 166);
            this.hireDateText.Name = "hireDateText";
            this.hireDateText.Size = new System.Drawing.Size(183, 26);
            this.hireDateText.TabIndex = 5;
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.AutoSize = true;
            this.hireDateLabel.Location = new System.Drawing.Point(210, 143);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(77, 20);
            this.hireDateLabel.TabIndex = 22;
            this.hireDateLabel.Text = "Hire Date";
            // 
            // wageText
            // 
            this.wageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wageText.Location = new System.Drawing.Point(214, 218);
            this.wageText.Name = "wageText";
            this.wageText.Size = new System.Drawing.Size(183, 26);
            this.wageText.TabIndex = 7;
            this.wageText.TextChanged += new System.EventHandler(this.wageText_TextChanged);
            // 
            // storeSelect
            // 
            this.storeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeSelect.FormattingEnabled = true;
            this.storeSelect.Location = new System.Drawing.Point(217, 272);
            this.storeSelect.Name = "storeSelect";
            this.storeSelect.Size = new System.Drawing.Size(180, 28);
            this.storeSelect.Sorted = true;
            this.storeSelect.TabIndex = 9;
            this.storeSelect.SelectedIndexChanged += new System.EventHandler(this.storeSelect_SelectedIndexChanged);
            // 
            // departmentSelect
            // 
            this.departmentSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentSelect.FormattingEnabled = true;
            this.departmentSelect.Location = new System.Drawing.Point(23, 272);
            this.departmentSelect.Name = "departmentSelect";
            this.departmentSelect.Size = new System.Drawing.Size(180, 28);
            this.departmentSelect.Sorted = true;
            this.departmentSelect.TabIndex = 8;
            this.departmentSelect.SelectedIndexChanged += new System.EventHandler(this.departmentSelect_SelectedIndexChanged);
            // 
            // jobSelect
            // 
            this.jobSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobSelect.FormattingEnabled = true;
            this.jobSelect.Location = new System.Drawing.Point(23, 218);
            this.jobSelect.Name = "jobSelect";
            this.jobSelect.Size = new System.Drawing.Size(184, 28);
            this.jobSelect.Sorted = true;
            this.jobSelect.TabIndex = 6;
            this.jobSelect.SelectedIndexChanged += new System.EventHandler(this.jobSelect_SelectedIndexChanged);
            // 
            // departmentLabel
            // 
            this.departmentLabel.Location = new System.Drawing.Point(19, 249);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(109, 20);
            this.departmentLabel.TabIndex = 0;
            this.departmentLabel.Text = "Department";
            // 
            // wageDisplay
            // 
            this.wageDisplay.AutoSize = true;
            this.wageDisplay.Location = new System.Drawing.Point(210, 288);
            this.wageDisplay.Name = "wageDisplay";
            this.wageDisplay.Size = new System.Drawing.Size(0, 20);
            this.wageDisplay.TabIndex = 15;
            // 
            // wageLabel
            // 
            this.wageLabel.AutoSize = true;
            this.wageLabel.Location = new System.Drawing.Point(210, 195);
            this.wageLabel.Name = "wageLabel";
            this.wageLabel.Size = new System.Drawing.Size(74, 20);
            this.wageLabel.TabIndex = 13;
            this.wageLabel.Text = "Wage ($)";
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Location = new System.Drawing.Point(213, 249);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(48, 20);
            this.storeLabel.TabIndex = 12;
            this.storeLabel.Text = "Store";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(19, 195);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(68, 20);
            this.jobLabel.TabIndex = 11;
            this.jobLabel.Text = "Job Title";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(213, 114);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(184, 26);
            this.phoneText.TabIndex = 3;
            this.phoneText.TextChanged += new System.EventHandler(this.phoneText_TextChanged);
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(23, 114);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(184, 26);
            this.addressText.TabIndex = 2;
            this.addressText.TextChanged += new System.EventHandler(this.addressText_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(210, 91);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Phone Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(19, 91);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(213, 62);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(184, 26);
            this.lastNameText.TabIndex = 10;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(19, 39);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(23, 62);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(184, 26);
            this.firstNameText.TabIndex = 0;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(319, 337);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 33);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 375);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.personalInfoGroup);
            this.Name = "EditEmployee";
            this.Text = "Edit Employee";
            this.personalInfoGroup.ResumeLayout(false);
            this.personalInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personalInfoGroup;
        private System.Windows.Forms.TextBox wageText;
        private System.Windows.Forms.ComboBox storeSelect;
        private System.Windows.Forms.ComboBox departmentSelect;
        private System.Windows.Forms.ComboBox jobSelect;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label wageDisplay;
        private System.Windows.Forms.Label wageLabel;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox dobText;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox hireDateText;
        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.Button submitButton;
    }
}