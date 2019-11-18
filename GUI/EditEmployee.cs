using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditEmployee : ModifyEmployee
    {
        public EditEmployee()
        {
            InitializeComponent();
            this.employeeIdInformation.Information.AllowTypeChange = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = this.employeeIdInformation.Information.SelectedEmployee.EmployeeId;
            this.employees[id] = this.employeeIdInformation.Information.SelectedEmployee;
        }


    }
}
