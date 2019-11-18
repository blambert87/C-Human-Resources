using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Business;

namespace GUI
{
    public partial class EmployeeIdInformation : UserControl
    {
        private EmployeeCollection employees = null;

        public EmployeeIdInformation()
        {
            InitializeComponent();
        }

        public EmployeeCollection Employees
        {
            get { return this.employees; }
            set 
            { 
                this.employees = value;
                //this.employeeIdDropDown.DataSource = value;
                if (value != null)
                {
                    this.employeeIdDropDown.Items.Clear();
                    foreach (IEmployee employee in value)
                    {
                        this.employeeIdDropDown.Items.Add(employee.EmployeeId);
                    }
                }
            }
        }

        public EmployeeInformation Information
        {
            get { return this.employeeInformation; }
        }

        private void employeeIdDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.employeeInformation.SelectedEmployee = this.employees[Convert.ToInt32(this.employeeIdDropDown.SelectedItem)];
        }
    }
}
