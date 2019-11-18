namespace GUI
{
    partial class ModifyEmployee
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
            this.employeeIdInformation = new GUI.EmployeeIdInformation();
            this.SuspendLayout();
            // 
            // employeeIdInformation
            // 
            this.employeeIdInformation.Employees = null;
            this.employeeIdInformation.Location = new System.Drawing.Point(3, 3);
            this.employeeIdInformation.Name = "employeeIdInformation";
            this.employeeIdInformation.Size = new System.Drawing.Size(295, 471);
            this.employeeIdInformation.TabIndex = 0;
            // 
            // ModifyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeIdInformation);
            this.Name = "ModifyEmployee";
            this.Size = new System.Drawing.Size(298, 483);
            this.ResumeLayout(false);

        }

        #endregion

        protected EmployeeIdInformation employeeIdInformation;

    }
}
