using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IContractEmployee : IEmployee
    {
        Fee Fee { get; }
    }
}
