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
    public partial class EmployeeInformation : UserControl
    {
        private IEmployee selectedEmployee = null;
        

        public EmployeeInformation()
        {
            InitializeComponent();
            this.UpdateView();

        }

        public IEmployee SelectedEmployee
        {
            get
            {
                if (this.selectedEmployee == null)
                {
                    if (this.fullTimeRadioButton.Checked)
                    {
                        this.selectedEmployee = new FullTimeEmployee(this.firstNameTextBox.Text, this.lastNameTextBox.Text);
                        (this.selectedEmployee as IFullTimeEmployee).Salary.Amount = this.fullTimeCompensation.Salary;
                    }
                    else if (this.partTimeRadioButton.Checked)
                    {
                        this.selectedEmployee = new PartTimeEmployee(this.firstNameTextBox.Text, this.lastNameTextBox.Text);
                        (this.selectedEmployee as IPartTimeEmployee).Wage.WorkingHours = this.partTimeCompensation.WorkingHours;
                        (this.selectedEmployee as IPartTimeEmployee).Wage.HourlyPay = this.partTimeCompensation.HourlyPay;
                    }
                    else if (this.contractRadioButton.Checked)
                    {
                        this.selectedEmployee = new ContractEmployee(this.firstNameTextBox.Text, this.lastNameTextBox.Text);
                        (this.selectedEmployee as IContractEmployee).Fee.Amount = this.contractCompensation.Fee;
                    }
                }
                else
                {
                    this.selectedEmployee.FirstName = this.firstNameTextBox.Text;
                    this.selectedEmployee.LastName = this.lastNameTextBox.Text;

                    if (this.selectedEmployee is IFullTimeEmployee)
                    {
                        (this.selectedEmployee as IFullTimeEmployee).Salary.Amount = this.fullTimeCompensation.Salary;
                    }
                    else if (this.selectedEmployee is IPartTimeEmployee)
                    {
                        (this.selectedEmployee as IPartTimeEmployee).Wage.WorkingHours = this.partTimeCompensation.WorkingHours;
                        (this.selectedEmployee as IPartTimeEmployee).Wage.HourlyPay = this.partTimeCompensation.HourlyPay;
                    }
                    else if (this.selectedEmployee is IContractEmployee)
                    {
                        (this.selectedEmployee as IContractEmployee).Fee.Amount = this.contractCompensation.Fee;
                    }
                }

                this.selectedEmployee.Address.StreetAddress = this.addressTextBox.Text;
                this.selectedEmployee.Address.City = this.cityTextBox.Text;
                this.selectedEmployee.Address.State = this.stateDropDown.SelectedItem.ToString();
                this.selectedEmployee.Address.ZipCode = Convert.ToInt32(this.zipTextBox.Text);

                return this.selectedEmployee;
            }
            set
            {
                this.selectedEmployee = value;

                this.firstNameTextBox.Text = this.selectedEmployee.FirstName;
                this.lastNameTextBox.Text = this.selectedEmployee.LastName;

                this.addressTextBox.Text = this.selectedEmployee.Address.StreetAddress;
                this.cityTextBox.Text = this.selectedEmployee.Address.City;
                this.stateDropDown.SelectedItem = this.selectedEmployee.Address.State;
                this.zipTextBox.Text = this.selectedEmployee.Address.ZipCode.ToString();

                if (this.selectedEmployee is IFullTimeEmployee)
                {
                    this.fullTimeRadioButton.Checked = true;
                    this.fullTimeCompensation.Salary = (this.selectedEmployee as IFullTimeEmployee).Salary.Amount;
                }
                else if (this.selectedEmployee is IPartTimeEmployee)
                {
                    this.partTimeRadioButton.Checked = true;
                    this.partTimeCompensation.WorkingHours = (this.selectedEmployee as IPartTimeEmployee).Wage.WorkingHours;
                    this.partTimeCompensation.HourlyPay = (this.selectedEmployee as IPartTimeEmployee).Wage.HourlyPay;
                }
                else if (this.selectedEmployee is IContractEmployee)
                {
                    this.contractRadioButton.Checked = true;
                    this.contractCompensation.Fee = (this.selectedEmployee as IContractEmployee).Fee.Amount;
                }
            }
        }

        public bool AllowTypeChange
        {
            set { this.typeGroupBox.Enabled = value; }
        }

        public bool AllowChange
        {
            set 
            {
                this.firstNameTextBox.Enabled =
                this.lastNameTextBox.Enabled =
                this.addressTextBox.Enabled =
                this.cityTextBox.Enabled =
                this.stateDropDown.Enabled =
                this.zipTextBox.Enabled =
                this.compensationGroupBox.Enabled = value;
            }

        }

        private void fullTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.fullTimeCompensation.BringToFront();
            this.UpdateView();
        }

        private void partTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.partTimeCompensation.BringToFront();
            this.UpdateView();
        }

        private void contractRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.contractCompensation.BringToFront();
            this.UpdateView();
        }

        private void UpdateView()
        {
            if (!this.fullTimeRadioButton.Checked &&
                !this.partTimeRadioButton.Checked &&
                !this.contractRadioButton.Checked)
            {
                this.compensationGroupBox.Visible = false;
            }
            else
            {
                this.compensationGroupBox.Visible = true;
            }
        }



        public void Clear()
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.addressTextBox.Clear();
            this.cityTextBox.Clear();
            this.stateDropDown.SelectedIndex = -1;
            this.zipTextBox.Clear();
            this.fullTimeRadioButton.Checked = false;
            this.partTimeRadioButton.Checked = false;
            this.contractRadioButton.Checked = false;
            this.selectedEmployee = null;
        }
    }
}
