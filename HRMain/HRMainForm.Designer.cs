namespace HRMain
{
    partial class HRMainForm
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
            this.actionsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcome = new GUI.Welcome();
            this.addEmployee = new GUI.AddEmployee();
            this.editEmployee = new GUI.EditEmployee();
            this.deleteEmployee = new GUI.DeleteEmployee();
            this.listEmployee = new GUI.ListEmployee();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.messagetoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionsMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsMenuStrip
            // 
            this.actionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.actionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.actionsMenuStrip.Name = "actionsMenuStrip";
            this.actionsMenuStrip.Size = new System.Drawing.Size(464, 24);
            this.actionsMenuStrip.TabIndex = 0;
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.listToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // welcome
            // 
            this.welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome.Location = new System.Drawing.Point(0, 24);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(464, 579);
            this.welcome.TabIndex = 4;
            // 
            // addEmployee
            // 
            this.addEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmployee.Employees = null;
            this.addEmployee.Location = new System.Drawing.Point(0, 24);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(464, 579);
            this.addEmployee.TabIndex = 5;
            // 
            // editEmployee
            // 
            this.editEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editEmployee.Employees = null;
            this.editEmployee.Location = new System.Drawing.Point(0, 24);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(464, 579);
            this.editEmployee.TabIndex = 3;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteEmployee.Employees = null;
            this.deleteEmployee.Location = new System.Drawing.Point(0, 24);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(464, 579);
            this.deleteEmployee.TabIndex = 2;
            // 
            // listEmployee
            // 
            this.listEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEmployee.Employees = null;
            this.listEmployee.Location = new System.Drawing.Point(0, 24);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(464, 579);
            this.listEmployee.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messagetoolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 581);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(464, 22);
            this.statusStrip.TabIndex = 6;
            // 
            // messagetoolStripStatusLabel
            // 
            this.messagetoolStripStatusLabel.Name = "messagetoolStripStatusLabel";
            this.messagetoolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // HRMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 603);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.editEmployee);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.listEmployee);
            this.Controls.Add(this.actionsMenuStrip);
            this.MainMenuStrip = this.actionsMenuStrip;
            this.Name = "HRMainForm";
            this.Text = "Human Resources";
            this.actionsMenuStrip.ResumeLayout(false);
            this.actionsMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip actionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private GUI.ListEmployee listEmployee;
        private GUI.DeleteEmployee deleteEmployee;
        private GUI.EditEmployee editEmployee;
        private GUI.Welcome welcome;
        private GUI.AddEmployee addEmployee;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel messagetoolStripStatusLabel;
    }
}

