using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public delegate double IncomeRetriever();

    public abstract class Employee : IEmployee
    {            
        private int employeeId;
        private string firstName;
        private string lastName;
        protected EmployeeType type;
        private Address address = new Address();

        protected IncomeRetriever earningsRetriever = null;
        protected IncomeRetriever deductionsRetriever = null;
        protected IncomeRetriever netPayRetriever = null;

        public Employee(string firstName, EmployeeType type)
        {
            this.firstName = firstName;
            this.type = type;
        }

        public Employee(string firstName, string lastName, EmployeeType type)
            : this(firstName, type)
        {
            this.lastName = lastName;
        }

        public int EmployeeId
        {
            get { return this.employeeId;}
            internal set { this.employeeId = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Address Address
        {
            get { return this.address; }
        }

        public EmployeeType Type
        {
            get { return this.type; }
        }

        public override string ToString()
        {
            return this.employeeId.ToString();
        }

        #region IEmployee Members


        public IncomeRetriever Earnings
        {
            get { return this.earningsRetriever; }
        }

        public IncomeRetriever Deductions
        {
            get { return this.deductionsRetriever; }
        }

        public IncomeRetriever NetPay
        {
            get { return this.netPayRetriever; }
        }

        #endregion
    }

}
