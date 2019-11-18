namespace GUI
{
    partial class ContractCompensation
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
            this.feeTextBox = new GUI.HRTextBox();
            this.hrLabel1 = new GUI.HRLabel();
            this.SuspendLayout();
            // 
            // feeTextBox
            // 
            this.feeTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.feeTextBox.Location = new System.Drawing.Point(58, 15);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(109, 21);
            this.feeTextBox.TabIndex = 3;
            // 
            // hrLabel1
            // 
            this.hrLabel1.AutoSize = true;
            this.hrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrLabel1.Location = new System.Drawing.Point(11, 18);
            this.hrLabel1.Name = "hrLabel1";
            this.hrLabel1.Size = new System.Drawing.Size(28, 15);
            this.hrLabel1.TabIndex = 2;
            this.hrLabel1.Text = "Fee";
            // 
            // ContractCompensation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.hrLabel1);
            this.Name = "ContractCompensation";
            this.Size = new System.Drawing.Size(180, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRTextBox feeTextBox;
        private HRLabel hrLabel1;
    }
}
