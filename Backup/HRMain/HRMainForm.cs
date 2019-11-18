using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;

namespace HRMain
{
    public partial class HRMainForm : Form
    {
        private EmployeeCollection employees = new EmployeeCollection();

        public HRMainForm()
        {
            InitializeComponent();

            this.addEmployee.EmployeeChanged += new GUI.EmployeeChangeEventHandler(addEmployee_EmployeeChanged);
        }

        void addEmployee_EmployeeChanged(object sender, GUI.EmployeeChangeEventArgs e)
        {
            this.messagetoolStripStatusLabel.Text = e.Message;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addEmployee.BringToFront();
            this.messagetoolStripStatusLabel.Text = "Add a new employee";
            this.addEmployee.Employees = this.employees;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editEmployee.BringToFront();
            this.messagetoolStripStatusLabel.Text = "Edit an existing employee";
            this.editEmployee.Employees = this.employees;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.deleteEmployee.BringToFront();
            this.messagetoolStripStatusLabel.Text = "Delete an existing employee";
            this.deleteEmployee.Employees = this.employees;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listEmployee.BringToFront();
            this.messagetoolStripStatusLabel.Text = "List all employees";
            this.listEmployee.Employees = this.employees;
        }
    }
}