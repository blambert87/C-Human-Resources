using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddEmployee : ManageEmployee
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.employees.Add(this.employeeInformation.SelectedEmployee);
            this.employeeInformation.Clear();
            
            EmployeeChangeEventArgs eventArgs = new EmployeeChangeEventArgs();
            eventArgs.Message = string.Format("Employee {0} has been added", this.employees.NextEmployeeId);
            this.OnEmployeeChanged(eventArgs);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.employeeInformation.Clear();
        }
    }
}
