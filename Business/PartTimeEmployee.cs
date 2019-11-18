using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PartTimeEmployee : Employee, IPartTimeEmployee
    {
        private Wage wage = new Wage();

        public PartTimeEmployee(string firstName)
            : this(firstName, null)
        {
        }

        public PartTimeEmployee(string firstName, string lastName)
            : base(firstName, lastName, EmployeeType.PartTime)
        {
            this.earningsRetriever = new IncomeRetriever(this.GetGrossWage);
            this.deductionsRetriever = new IncomeRetriever(this.GetWageDeductions);
            this.netPayRetriever = new IncomeRetriever(this.GetNetWage);
        }

        public Wage Wage
        {
            get { return this.wage; }        
        }

        private double GetGrossWage()
        {
            return this.wage.HourlyPay * this.wage.WorkingHours;
        }

        private double GetWageDeductions()
        {
            double grossWage = this.GetGrossWage();
            return grossWage * 0.25;
        }

        private double GetNetWage()
        {
            double income = this.GetGrossWage();
            double deductions = this.GetWageDeductions();
            return income - deductions;
        }
    }
}
