using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class DeleteEmployee : ModifyEmployee
    {
        public DeleteEmployee()
        {
            InitializeComponent();
            this.employeeIdInformation.Information.AllowChange = false;
        }
    }
}
