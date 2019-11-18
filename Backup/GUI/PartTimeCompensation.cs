using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class PartTimeCompensation : UserControl
    {
        public PartTimeCompensation()
        {
            InitializeComponent();
        }

        public double WorkingHours
        {
            get { return Convert.ToDouble(this.workingHoursTextBox.Text); }
            set { this.workingHoursTextBox.Text = value.ToString(); }
        }

        public double HourlyPay
        {
            get { return Convert.ToDouble(this.hourlyPayTextBox.Text); }
            set { this.hourlyPayTextBox.Text = value.ToString(); }
        }
    }
}
