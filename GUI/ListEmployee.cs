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
    public partial class ListEmployee : ManageEmployee
    {
        public ListEmployee()
        {
            InitializeComponent();
            this.employeeInformation.AllowChange = false;
        }

        public override Business.EmployeeCollection Employees
        {
            get
            {
                return base.Employees;
            }
            set
            {
                base.Employees = value;

                if (value != null)
                {
                    this.employeeIdsListBox.Items.Clear();
                    foreach (IEmployee employee in this.employees)
                    {
                        this.employeeIdsListBox.Items.Add(employee.EmployeeId);
                    }
                }
            }
        }

        private void employeeIdsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEmployee listedEmployee = this.employees[Convert.ToInt32(this.employeeIdsListBox.SelectedItem)];
            this.employeeInformation.SelectedEmployee = listedEmployee;

            //if (listedEmployee is IFullTimeEmployee)
            //{
            //    this.earningsValueLabel.Text = (listedEmployee as IFullTimeEmployee).GetGrossSalary();
            //    this.deductionsValueLabel.Text = (listedEmployee as IFullTimeEmployee).GetSalaryDeductions();
            //    this.netPayValueLabel.Text = (listedEmployee as IFullTimeEmployee).GetNetSalary();
            //}
            //else if (listedEmployee is IPartTimeEmployee)
            //{
            //    this.earningsValueLabel.Text = (listedEmployee as IPartTimeEmployee).GetGrossWage();
            //    this.deductionsValueLabel.Text = (listedEmployee as IPartTimeEmployee).GetWageDeductions();
            //    this.netPayValueLabel.Text = (listedEmployee as IPartTimeEmployee).GetNetWage();
            //}
            //if (listedEmployee is IContractEmployee)
            //{
            //    this.earningsValueLabel.Text = (listedEmployee as IContractEmployee).GetGrossFee();
            //    this.deductionsValueLabel.Text = (listedEmployee as IContractEmployee).GetFeeDeductions();
            //    this.netPayValueLabel.Text = (listedEmployee as IContractEmployee).GetNetFee();
            //}

            // Instead of checking the type of each employee, we can use the delegates instead.

            this.earningsValueLabel.Text = listedEmployee.Earnings().ToString();
            this.deductionsValueLabel.Text = listedEmployee.Deductions().ToString();
            this.netPayValueLabel.Text = listedEmployee.NetPay().ToString();

        }
    }
}
