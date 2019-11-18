using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IPartTimeEmployee : IEmployee
    {
        Wage Wage { get; }
    }
}
