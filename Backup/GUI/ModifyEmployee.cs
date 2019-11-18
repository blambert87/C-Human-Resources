using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ModifyEmployee : ManageEmployee
    {        
        public ModifyEmployee()
        {
            InitializeComponent();
        }

        public sealed override Business.EmployeeCollection Employees
        {
            get
            {
                return base.Employees;
            }
            set
            {
                base.Employees = value;
                this.employeeIdInformation.Employees = value;
            }
        }
    }
}
