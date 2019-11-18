using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ContractEmployee : Employee, IContractEmployee
    {
        private Fee fee = new Fee();

        public ContractEmployee(string firstName)
            : this(firstName, null)
        {
        }

        public ContractEmployee(string firstName, string lastName)
            : base(firstName, lastName, EmployeeType.Contract)
        {
            this.earningsRetriever = new IncomeRetriever(this.GetGrossFee);
            this.deductionsRetriever = new IncomeRetriever(this.GetFeeDeductions);
            this.netPayRetriever = new IncomeRetriever(this.GetNetFee);
        }

        public Fee Fee
        {
            get { return this.fee; }
        }

        private double GetGrossFee()
        {
            return this.fee.Amount;
        }

        private double GetFeeDeductions()
        {
            return this.fee.Amount * 0.20;
        }

        private double GetNetFee()
        {
            double income = this.GetGrossFee();
            double deductions = this.GetFeeDeductions();
            return income - deductions;
        }

    }
}
