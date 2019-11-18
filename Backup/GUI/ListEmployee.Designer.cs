namespace GUI
{
    partial class ListEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeIdsListBox = new GUI.HRListBox();
            this.hrLabel1 = new GUI.HRLabel();
            this.employeeInformation = new GUI.EmployeeInformation();
            this.totalEmployeesHeaderLabel = new GUI.HRLabel();
            this.totalEmployeesValueLabel = new GUI.HRLabel();
            this.hrGroupBox1 = new GUI.HRGroupBox();
            this.netPayValueLabel = new GUI.HRLabel();
            this.netPayHeaderLabel = new GUI.HRLabel();
            this.deductionsValueLabel = new GUI.HRLabel();
            this.deductionsHeaderLabel = new GUI.HRLabel();
            this.earningsValueLabel = new GUI.HRLabel();
            this.earningsHeaderLabel = new GUI.HRLabel();
            this.hrGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIdsListBox
            // 
            this.employeeIdsListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdsListBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeIdsListBox.FormattingEnabled = true;
            this.employeeIdsListBox.ItemHeight = 15;
            this.employeeIdsListBox.Location = new System.Drawing.Point(7, 37);
            this.employeeIdsListBox.Name = "employeeIdsListBox";
            this.employeeIdsListBox.Size = new System.Drawing.Size(140, 484);
            this.employeeIdsListBox.TabIndex = 0;
            this.employeeIdsListBox.SelectedIndexChanged += new System.EventHandler(this.employeeIdsListBox_SelectedIndexChanged);
            // 
            // hrLabel1
            // 
            this.hrLabel1.AutoSize = true;
            this.hrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrLabel1.Location = new System.Drawing.Point(4, 15);
            this.hrLabel1.Name = "hrLabel1";
            this.hrLabel1.Size = new System.Drawing.Size(82, 15);
            this.hrLabel1.TabIndex = 1;
            this.hrLabel1.Text = "Employee Ids";
            // 
            // employeeInformation
            // 
            this.employeeInformation.Location = new System.Drawing.Point(159, 15);
            this.employeeInformation.Name = "employeeInformation";
            this.employeeInformation.Size = new System.Drawing.Size(285, 417);
            this.employeeInformation.TabIndex = 2;
            // 
            // totalEmployeesHeaderLabel
            // 
            this.totalEmployeesHeaderLabel.AutoSize = true;
            this.totalEmployeesHeaderLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEmployeesHeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalEmployeesHeaderLabel.Location = new System.Drawing.Point(4, 530);
            this.totalEmployeesHeaderLabel.Name = "totalEmployeesHeaderLabel";
            this.totalEmployeesHeaderLabel.Size = new System.Drawing.Size(102, 15);
            this.totalEmployeesHeaderLabel.TabIndex = 3;
            this.totalEmployeesHeaderLabel.Text = "Total Employees:";
            // 
            // totalEmployeesValueLabel
            // 
            this.totalEmployeesValueLabel.AutoSize = true;
            this.totalEmployeesValueLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEmployeesValueLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.totalEmployeesValueLabel.Location = new System.Drawing.Point(112, 530);
            this.totalEmployeesValueLabel.Name = "totalEmployeesValueLabel";
            this.totalEmployeesValueLabel.Size = new System.Drawing.Size(0, 15);
            this.totalEmployeesValueLabel.TabIndex = 4;
            // 
            // hrGroupBox1
            // 
            this.hrGroupBox1.Controls.Add(this.netPayValueLabel);
            this.hrGroupBox1.Controls.Add(this.netPayHeaderLabel);
            this.hrGroupBox1.Controls.Add(this.deductionsValueLabel);
            this.hrGroupBox1.Controls.Add(this.deductionsHeaderLabel);
            this.hrGroupBox1.Controls.Add(this.earningsValueLabel);
            this.hrGroupBox1.Controls.Add(this.earningsHeaderLabel);
            this.hrGroupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrGroupBox1.Location = new System.Drawing.Point(176, 438);
            this.hrGroupBox1.Name = "hrGroupBox1";
            this.hrGroupBox1.Size = new System.Drawing.Size(256, 107);
            this.hrGroupBox1.TabIndex = 5;
            this.hrGroupBox1.TabStop = false;
            this.hrGroupBox1.Text = " Payment ";
            // 
            // netPayValueLabel
            // 
            this.netPayValueLabel.AutoSize = true;
            this.netPayValueLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPayValueLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.netPayValueLabel.Location = new System.Drawing.Point(166, 78);
            this.netPayValueLabel.Name = "netPayValueLabel";
            this.netPayValueLabel.Size = new System.Drawing.Size(0, 15);
            this.netPayValueLabel.TabIndex = 5;
            // 
            // netPayHeaderLabel
            // 
            this.netPayHeaderLabel.AutoSize = true;
            this.netPayHeaderLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPayHeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.netPayHeaderLabel.Location = new System.Drawing.Point(54, 78);
            this.netPayHeaderLabel.Name = "netPayHeaderLabel";
            this.netPayHeaderLabel.Size = new System.Drawing.Size(49, 15);
            this.netPayHeaderLabel.TabIndex = 4;
            this.netPayHeaderLabel.Text = "Net Pay";
            // 
            // deductionsValueLabel
            // 
            this.deductionsValueLabel.AutoSize = true;
            this.deductionsValueLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionsValueLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.deductionsValueLabel.Location = new System.Drawing.Point(165, 52);
            this.deductionsValueLabel.Name = "deductionsValueLabel";
            this.deductionsValueLabel.Size = new System.Drawing.Size(0, 15);
            this.deductionsValueLabel.TabIndex = 3;
            // 
            // deductionsHeaderLabel
            // 
            this.deductionsHeaderLabel.AutoSize = true;
            this.deductionsHeaderLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionsHeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.deductionsHeaderLabel.Location = new System.Drawing.Point(53, 52);
            this.deductionsHeaderLabel.Name = "deductionsHeaderLabel";
            this.deductionsHeaderLabel.Size = new System.Drawing.Size(70, 15);
            this.deductionsHeaderLabel.TabIndex = 2;
            this.deductionsHeaderLabel.Text = "Deductions";
            // 
            // earningsValueLabel
            // 
            this.earningsValueLabel.AutoSize = true;
            this.earningsValueLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsValueLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.earningsValueLabel.Location = new System.Drawing.Point(165, 27);
            this.earningsValueLabel.Name = "earningsValueLabel";
            this.earningsValueLabel.Size = new System.Drawing.Size(0, 15);
            this.earningsValueLabel.TabIndex = 1;
            // 
            // earningsHeaderLabel
            // 
            this.earningsHeaderLabel.AutoSize = true;
            this.earningsHeaderLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsHeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.earningsHeaderLabel.Location = new System.Drawing.Point(53, 27);
            this.earningsHeaderLabel.Name = "earningsHeaderLabel";
            this.earningsHeaderLabel.Size = new System.Drawing.Size(57, 15);
            this.earningsHeaderLabel.TabIndex = 0;
            this.earningsHeaderLabel.Text = "Earnings";
            // 
            // ListEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hrGroupBox1);
            this.Controls.Add(this.totalEmployeesValueLabel);
            this.Controls.Add(this.totalEmployeesHeaderLabel);
            this.Controls.Add(this.employeeInformation);
            this.Controls.Add(this.hrLabel1);
            this.Controls.Add(this.employeeIdsListBox);
            this.Name = "ListEmployee";
            this.Size = new System.Drawing.Size(455, 567);
            this.hrGroupBox1.ResumeLayout(false);
            this.hrGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRListBox employeeIdsListBox;
        private HRLabel hrLabel1;
        private EmployeeInformation employeeInformation;
        private HRLabel totalEmployeesHeaderLabel;
        private HRLabel totalEmployeesValueLabel;
        private HRGroupBox hrGroupBox1;
        private HRLabel deductionsValueLabel;
        private HRLabel deductionsHeaderLabel;
        private HRLabel earningsValueLabel;
        private HRLabel earningsHeaderLabel;
        private HRLabel netPayValueLabel;
        private HRLabel netPayHeaderLabel;
    }
}
