using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Wage
    {        
        private double workingHours;
        private double hourlyPay;

        public double WorkingHours
        {
            get { return this.workingHours; }
            set { this.workingHours = value; }
        }

        public double HourlyPay
        {
            get { return this.hourlyPay; }
            set { this.hourlyPay = value; }
        }
    }
}
