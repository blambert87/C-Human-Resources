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
    public delegate void EmployeeChangeEventHandler(object sender, EmployeeChangeEventArgs e);

    public partial class ManageEmployee : UserControl
    {
        protected EmployeeCollection employees = null;

        public event EmployeeChangeEventHandler EmployeeChanged;

        protected void OnEmployeeChanged(EmployeeChangeEventArgs e)
        {
            // Check if any objects are subscribed/registered
            if (this.EmployeeChanged != null)
            {
                // Fire the event
                this.EmployeeChanged(this, e);
            }
        }

        public ManageEmployee()
        {
            InitializeComponent();
        }

        public virtual EmployeeCollection Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }
    }
}
