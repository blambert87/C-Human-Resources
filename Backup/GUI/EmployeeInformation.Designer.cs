namespace GUI
{
    partial class EmployeeInformation
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
            this.compensationGroupBox = new GUI.HRGroupBox();
            this.fullTimeCompensation = new GUI.FullTimeCompensation();
            this.partTimeCompensation = new GUI.PartTimeCompensation();
            this.contractCompensation = new GUI.ContractCompensation();
            this.typeGroupBox = new GUI.HRGroupBox();
            this.contractRadioButton = new System.Windows.Forms.RadioButton();
            this.partTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.fullTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.personalGroupBox = new GUI.HRGroupBox();
            this.zipTextBox = new GUI.HRTextBox();
            this.stateDropDown = new GUI.HRDropDown();
            this.cityTextBox = new GUI.HRTextBox();
            this.addressTextBox = new GUI.HRTextBox();
            this.lastNameTextBox = new GUI.HRTextBox();
            this.firstNameTextBox = new GUI.HRTextBox();
            this.zipLabel = new GUI.HRLabel();
            this.stateLabel = new GUI.HRLabel();
            this.cityLabel = new GUI.HRLabel();
            this.addressLabel = new GUI.HRLabel();
            this.hrLabel2 = new GUI.HRLabel();
            this.firstNameLabel = new GUI.HRLabel();
            this.compensationGroupBox.SuspendLayout();
            this.typeGroupBox.SuspendLayout();
            this.personalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // compensationGroupBox
            // 
            this.compensationGroupBox.Controls.Add(this.fullTimeCompensation);
            this.compensationGroupBox.Controls.Add(this.partTimeCompensation);
            this.compensationGroupBox.Controls.Add(this.contractCompensation);
            this.compensationGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compensationGroupBox.Location = new System.Drawing.Point(14, 284);
            this.compensationGroupBox.Name = "compensationGroupBox";
            this.compensationGroupBox.Size = new System.Drawing.Size(257, 118);
            this.compensationGroupBox.TabIndex = 2;
            this.compensationGroupBox.TabStop = false;
            this.compensationGroupBox.Text = " Compensation ";
            // 
            // fullTimeCompensation
            // 
            this.fullTimeCompensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullTimeCompensation.Location = new System.Drawing.Point(3, 17);
            this.fullTimeCompensation.Name = "fullTimeCompensation";
            this.fullTimeCompensation.Size = new System.Drawing.Size(251, 98);
            this.fullTimeCompensation.TabIndex = 2;
            // 
            // partTimeCompensation
            // 
            this.partTimeCompensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partTimeCompensation.Location = new System.Drawing.Point(3, 17);
            this.partTimeCompensation.Name = "partTimeCompensation";
            this.partTimeCompensation.Size = new System.Drawing.Size(251, 98);
            this.partTimeCompensation.TabIndex = 1;
            // 
            // contractCompensation
            // 
            this.contractCompensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractCompensation.Location = new System.Drawing.Point(3, 17);
            this.contractCompensation.Name = "contractCompensation";
            this.contractCompensation.Size = new System.Drawing.Size(251, 98);
            this.contractCompensation.TabIndex = 0;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.contractRadioButton);
            this.typeGroupBox.Controls.Add(this.partTimeRadioButton);
            this.typeGroupBox.Controls.Add(this.fullTimeRadioButton);
            this.typeGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeGroupBox.Location = new System.Drawing.Point(14, 206);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(257, 60);
            this.typeGroupBox.TabIndex = 1;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = " Type ";
            // 
            // contractRadioButton
            // 
            this.contractRadioButton.AutoSize = true;
            this.contractRadioButton.Location = new System.Drawing.Point(171, 27);
            this.contractRadioButton.Name = "contractRadioButton";
            this.contractRadioButton.Size = new System.Drawing.Size(74, 19);
            this.contractRadioButton.TabIndex = 2;
            this.contractRadioButton.TabStop = true;
            this.contractRadioButton.Text = "Contract";
            this.contractRadioButton.UseVisualStyleBackColor = true;
            this.contractRadioButton.CheckedChanged += new System.EventHandler(this.contractRadioButton_CheckedChanged);
            // 
            // partTimeRadioButton
            // 
            this.partTimeRadioButton.AutoSize = true;
            this.partTimeRadioButton.Location = new System.Drawing.Point(88, 27);
            this.partTimeRadioButton.Name = "partTimeRadioButton";
            this.partTimeRadioButton.Size = new System.Drawing.Size(77, 19);
            this.partTimeRadioButton.TabIndex = 1;
            this.partTimeRadioButton.TabStop = true;
            this.partTimeRadioButton.Text = "PartTime";
            this.partTimeRadioButton.UseVisualStyleBackColor = true;
            this.partTimeRadioButton.CheckedChanged += new System.EventHandler(this.partTimeRadioButton_CheckedChanged);
            // 
            // fullTimeRadioButton
            // 
            this.fullTimeRadioButton.AutoSize = true;
            this.fullTimeRadioButton.Location = new System.Drawing.Point(10, 27);
            this.fullTimeRadioButton.Name = "fullTimeRadioButton";
            this.fullTimeRadioButton.Size = new System.Drawing.Size(72, 19);
            this.fullTimeRadioButton.TabIndex = 0;
            this.fullTimeRadioButton.TabStop = true;
            this.fullTimeRadioButton.Text = "FullTime";
            this.fullTimeRadioButton.UseVisualStyleBackColor = true;
            this.fullTimeRadioButton.CheckedChanged += new System.EventHandler(this.fullTimeRadioButton_CheckedChanged);
            // 
            // personalGroupBox
            // 
            this.personalGroupBox.Controls.Add(this.zipTextBox);
            this.personalGroupBox.Controls.Add(this.stateDropDown);
            this.personalGroupBox.Controls.Add(this.cityTextBox);
            this.personalGroupBox.Controls.Add(this.addressTextBox);
            this.personalGroupBox.Controls.Add(this.lastNameTextBox);
            this.personalGroupBox.Controls.Add(this.firstNameTextBox);
            this.personalGroupBox.Controls.Add(this.zipLabel);
            this.personalGroupBox.Controls.Add(this.stateLabel);
            this.personalGroupBox.Controls.Add(this.cityLabel);
            this.personalGroupBox.Controls.Add(this.addressLabel);
            this.personalGroupBox.Controls.Add(this.hrLabel2);
            this.personalGroupBox.Controls.Add(this.firstNameLabel);
            this.personalGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalGroupBox.Location = new System.Drawing.Point(14, 14);
            this.personalGroupBox.Name = "personalGroupBox";
            this.personalGroupBox.Size = new System.Drawing.Size(257, 176);
            this.personalGroupBox.TabIndex = 0;
            this.personalGroupBox.TabStop = false;
            this.personalGroupBox.Text = " Personal ";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.zipTextBox.Location = new System.Drawing.Point(81, 145);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(57, 21);
            this.zipTextBox.TabIndex = 11;
            // 
            // stateDropDown
            // 
            this.stateDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateDropDown.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateDropDown.FormattingEnabled = true;
            this.stateDropDown.Items.AddRange(new object[] {
            "CA",
            "AZ",
            "FL",
            "TX",
            "NY"});
            this.stateDropDown.Location = new System.Drawing.Point(81, 119);
            this.stateDropDown.Name = "stateDropDown";
            this.stateDropDown.Size = new System.Drawing.Size(57, 23);
            this.stateDropDown.TabIndex = 10;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.cityTextBox.Location = new System.Drawing.Point(81, 95);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 21);
            this.cityTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.addressTextBox.Location = new System.Drawing.Point(81, 71);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(165, 21);
            this.addressTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.lastNameTextBox.Location = new System.Drawing.Point(81, 46);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 21);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.firstNameTextBox.Location = new System.Drawing.Point(81, 21);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(165, 21);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.zipLabel.Location = new System.Drawing.Point(21, 148);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(54, 15);
            this.zipLabel.TabIndex = 5;
            this.zipLabel.Text = "ZipCode";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.stateLabel.Location = new System.Drawing.Point(40, 122);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 15);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cityLabel.Location = new System.Drawing.Point(48, 98);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 15);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addressLabel.Location = new System.Drawing.Point(22, 74);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(53, 15);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // hrLabel2
            // 
            this.hrLabel2.AutoSize = true;
            this.hrLabel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrLabel2.Location = new System.Drawing.Point(7, 49);
            this.hrLabel2.Name = "hrLabel2";
            this.hrLabel2.Size = new System.Drawing.Size(68, 15);
            this.hrLabel2.TabIndex = 1;
            this.hrLabel2.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(68, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.compensationGroupBox);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.personalGroupBox);
            this.Name = "EmployeeInformation";
            this.Size = new System.Drawing.Size(285, 417);
            this.compensationGroupBox.ResumeLayout(false);
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.personalGroupBox.ResumeLayout(false);
            this.personalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HRGroupBox personalGroupBox;
        private HRLabel cityLabel;
        private HRLabel addressLabel;
        private HRLabel hrLabel2;
        private HRLabel firstNameLabel;
        private HRTextBox addressTextBox;
        private HRTextBox lastNameTextBox;
        private HRTextBox firstNameTextBox;
        private HRLabel zipLabel;
        private HRLabel stateLabel;
        private HRTextBox zipTextBox;
        private HRDropDown stateDropDown;
        private HRTextBox cityTextBox;
        private HRGroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton contractRadioButton;
        private System.Windows.Forms.RadioButton partTimeRadioButton;
        private System.Windows.Forms.RadioButton fullTimeRadioButton;
        private HRGroupBox compensationGroupBox;
        private FullTimeCompensation fullTimeCompensation;
        private PartTimeCompensation partTimeCompensation;
        private ContractCompensation contractCompensation;
    }
}
