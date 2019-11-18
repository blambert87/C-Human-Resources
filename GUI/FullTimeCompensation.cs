using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FullTimeCompensation : UserControl
    {
        public FullTimeCompensation()
        {
            InitializeComponent();
        }

        public double Salary
        {
            get { return Convert.ToDouble(this.salaryTextBox.Text); }
            set { this.salaryTextBox.Text = value.ToString(); }
        }
    }
}
