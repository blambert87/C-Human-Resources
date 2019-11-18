using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class FullTimeEmployee : Employee, IFullTimeEmployee
    {
        private Salary salary = new Salary();

        public FullTimeEmployee(string firstName)
            : this(firstName, null)
        {
        }

        public FullTimeEmployee(string firstName, string lastName)
            : base(firstName, lastName, EmployeeType.FullTime)
        {
            this.earningsRetriever = new IncomeRetriever(this.GetGrossSalary);
            this.deductionsRetriever = new IncomeRetriever(this.GetSalaryDeductions);
            this.netPayRetriever = new IncomeRetriever(this.GetNetSalary);
        }

        public Salary Salary
        {
            get { return this.salary; }
        }

        private double GetGrossSalary()
        {
            return this.salary.Amount + this.salary.Bonus;
        }

        private double GetSalaryDeductions()
        {
            double totalIncome = this.salary.Amount + this.salary.Bonus;
            return totalIncome - (totalIncome * 0.45);
        }

        private double GetNetSalary()
        {
            double income = this.GetGrossSalary();
            double deductions = this.GetSalaryDeductions();
            return income - deductions;
        }

    }
}
