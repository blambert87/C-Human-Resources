using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IEmployee
    {
        int EmployeeId { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        Address Address { get; }
        EmployeeType Type { get;}

        IncomeRetriever Earnings { get; }
        IncomeRetriever Deductions { get; }
        IncomeRetriever NetPay { get; }
    }
}
