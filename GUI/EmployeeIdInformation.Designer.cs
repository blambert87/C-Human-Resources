namespace GUI
{
    partial class EmployeeIdInformation
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
            this.employeeInformation = new GUI.EmployeeInformation();
            this.employeeIdDropDown = new GUI.HRDropDown();
            this.hrLabel1 = new GUI.HRLabel();
            this.SuspendLayout();
            // 
            // employeeInformation1
            // 
            this.employeeInformation.Location = new System.Drawing.Point(4, 43);
            this.employeeInformation.Name = "employeeInformation1";
            this.employeeInformation.Size = new System.Drawing.Size(283, 417);
            this.employeeInformation.TabIndex = 2;
            // 
            // employeeIdDropDown
            // 
            this.employeeIdDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeIdDropDown.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdDropDown.FormattingEnabled = true;
            this.employeeIdDropDown.Location = new System.Drawing.Point(113, 12);
            this.employeeIdDropDown.Name = "employeeIdDropDown";
            this.employeeIdDropDown.Size = new System.Drawing.Size(121, 23);
            this.employeeIdDropDown.TabIndex = 1;
            this.employeeIdDropDown.SelectedIndexChanged += new System.EventHandler(this.employeeIdDropDown_SelectedIndexChanged);
            // 
            // hrLabel1
            // 
            this.hrLabel1.AutoSize = true;
            this.hrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrLabel1.Location = new System.Drawing.Point(29, 15);
            this.hrLabel1.Name = "hrLabel1";
            this.hrLabel1.Size = new System.Drawing.Size(78, 15);
            this.hrLabel1.TabIndex = 0;
            this.hrLabel1.Text = "Employee Id:";
            // 
            // EmployeeIdInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeInformation);
            this.Controls.Add(this.employeeIdDropDown);
            this.Controls.Add(this.hrLabel1);
            this.Name = "EmployeeIdInformation";
            this.Size = new System.Drawing.Size(295, 471);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRLabel hrLabel1;
        private HRDropDown employeeIdDropDown;
        private EmployeeInformation employeeInformation;
    }
}
