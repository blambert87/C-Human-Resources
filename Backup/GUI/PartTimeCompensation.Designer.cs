namespace GUI
{
    partial class PartTimeCompensation
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
            this.hourlyPayTextBox = new GUI.HRTextBox();
            this.hrLabel2 = new GUI.HRLabel();
            this.workingHoursTextBox = new GUI.HRTextBox();
            this.hrLabel1 = new GUI.HRLabel();
            this.SuspendLayout();
            // 
            // hourlyPayTextBox
            // 
            this.hourlyPayTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.hourlyPayTextBox.Location = new System.Drawing.Point(101, 35);
            this.hourlyPayTextBox.Name = "hourlyPayTextBox";
            this.hourlyPayTextBox.Size = new System.Drawing.Size(38, 21);
            this.hourlyPayTextBox.TabIndex = 5;
            // 
            // hrLabel2
            // 
            this.hrLabel2.AutoSize = true;
            this.hrLabel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrLabel2.Location = new System.Drawing.Point(30, 41);
            this.hrLabel2.Name = "hrLabel2";
            this.hrLabel2.Size = new System.Drawing.Size(65, 15);
            this.hrLabel2.TabIndex = 4;
            this.hrLabel2.Text = "Hourly Pay";
            // 
            // workingHoursTextBox
            // 
            this.workingHoursTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingHoursTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.workingHoursTextBox.Location = new System.Drawing.Point(101, 8);
            this.workingHoursTextBox.Name = "workingHoursTextBox";
            this.workingHoursTextBox.Size = new System.Drawing.Size(62, 21);
            this.workingHoursTextBox.TabIndex = 3;
            // 
            // hrLabel1
            // 
            this.hrLabel1.AutoSize = true;
            this.hrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrLabel1.Location = new System.Drawing.Point(6, 14);
            this.hrLabel1.Name = "hrLabel1";
            this.hrLabel1.Size = new System.Drawing.Size(89, 15);
            this.hrLabel1.TabIndex = 2;
            this.hrLabel1.Text = "Working Hours";
            // 
            // PartTimeCompensation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hourlyPayTextBox);
            this.Controls.Add(this.hrLabel2);
            this.Controls.Add(this.workingHoursTextBox);
            this.Controls.Add(this.hrLabel1);
            this.Name = "PartTimeCompensation";
            this.Size = new System.Drawing.Size(179, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRTextBox workingHoursTextBox;
        private HRLabel hrLabel1;
        private HRTextBox hourlyPayTextBox;
        private HRLabel hrLabel2;
    }
}
