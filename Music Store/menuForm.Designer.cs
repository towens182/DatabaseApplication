namespace Music_Store
{
    partial class MenuForm
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
            this.titleLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeButton = new System.Windows.Forms.Button();
            this.instrumentButton = new System.Windows.Forms.Button();
            this.hiringButton = new System.Windows.Forms.Button();
            this.storePerformance = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(13, 13);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(570, 24);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Welcome to the Music Store, select an option below to get started...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.storePerformance);
            this.groupBox1.Controls.Add(this.employeeButton);
            this.groupBox1.Controls.Add(this.instrumentButton);
            this.groupBox1.Controls.Add(this.hiringButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // employeeButton
            // 
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.Location = new System.Drawing.Point(6, 119);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(264, 99);
            this.employeeButton.TabIndex = 2;
            this.employeeButton.Text = "Employee Management";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // instrumentButton
            // 
            this.instrumentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentButton.Location = new System.Drawing.Point(285, 22);
            this.instrumentButton.Name = "instrumentButton";
            this.instrumentButton.Size = new System.Drawing.Size(273, 91);
            this.instrumentButton.TabIndex = 1;
            this.instrumentButton.Text = "Instrument Inquiry";
            this.instrumentButton.UseVisualStyleBackColor = true;
            this.instrumentButton.Click += new System.EventHandler(this.instrumentButton_Click);
            // 
            // hiringButton
            // 
            this.hiringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiringButton.Location = new System.Drawing.Point(6, 22);
            this.hiringButton.Name = "hiringButton";
            this.hiringButton.Size = new System.Drawing.Size(264, 91);
            this.hiringButton.TabIndex = 0;
            this.hiringButton.Text = "Hiring Center";
            this.hiringButton.UseVisualStyleBackColor = true;
            this.hiringButton.Click += new System.EventHandler(this.hiringButton_Click);
            // 
            // storePerformance
            // 
            this.storePerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storePerformance.Location = new System.Drawing.Point(285, 119);
            this.storePerformance.Name = "storePerformance";
            this.storePerformance.Size = new System.Drawing.Size(273, 99);
            this.storePerformance.TabIndex = 3;
            this.storePerformance.Text = "Store Performance";
            this.storePerformance.UseVisualStyleBackColor = true;
            this.storePerformance.Click += new System.EventHandler(this.storePerformance_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLable);
            this.Name = "MenuForm";
            this.Text = "Music Store";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button instrumentButton;
        private System.Windows.Forms.Button hiringButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button storePerformance;
    }
}