namespace GUI
{
    partial class FullTimeCompensation
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
            this.hrLabel1 = new GUI.HRLabel();
            this.salaryTextBox = new GUI.HRTextBox();
            this.SuspendLayout();
            // 
            // hrLabel1
            // 
            this.hrLabel1.AutoSize = true;
            this.hrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrLabel1.Location = new System.Drawing.Point(12, 23);
            this.hrLabel1.Name = "hrLabel1";
            this.hrLabel1.Size = new System.Drawing.Size(41, 15);
            this.hrLabel1.TabIndex = 0;
            this.hrLabel1.Text = "Salary";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.salaryTextBox.Location = new System.Drawing.Point(59, 20);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(109, 21);
            this.salaryTextBox.TabIndex = 1;
            // 
            // FullTimeCompensation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.hrLabel1);
            this.Name = "FullTimeCompensation";
            this.Size = new System.Drawing.Size(183, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRLabel hrLabel1;
        private HRTextBox salaryTextBox;
    }
}
