using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ContractCompensation : UserControl
    {
        public ContractCompensation()
        {
            InitializeComponent();
        }

        public double Fee
        {
            get { return Convert.ToDouble(this.feeTextBox.Text); }
            set { this.feeTextBox.Text = value.ToString(); }
        }
    }
}
