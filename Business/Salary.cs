using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Salary
    {        
        private double amount;
        private double bonus;

        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public double Bonus
        {
            get { return this.bonus; }
            set { this.bonus = value; }
        }
    }
}
