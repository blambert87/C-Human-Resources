using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class EmployeeCollection : IEnumerable<IEmployee>
    {
        private List<IEmployee> employees = new List<IEmployee>();
        private int nextEmployeeId = 1000;

        public void Add(IEmployee newEmployee)
        {
            (newEmployee as Employee).EmployeeId = ++this.nextEmployeeId;
            this.employees.Add(newEmployee);
        }

        public int NextEmployeeId
        {
            get { return this.nextEmployeeId; }
        }

        public IEmployee this[int employeeId]
        {
            get
            {
                foreach (IEmployee employee in this.employees)
                {
                    if (employee.EmployeeId == employeeId)
                    {
                        return employee;
                    }
                }

                return null;
            }
            set
            {
                for (int index = 0; index < this.employees.Count; index++)
                {
                    if (this.employees[index].EmployeeId == value.EmployeeId)
                    {
                        this.employees[index] = value;
                    }
                }
            }
        }

        #region IEnumerable<IEmployee> Members

        public IEnumerator<IEmployee> GetEnumerator()
        {
            return this.employees.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.employees.GetEnumerator();
        }

        #endregion
    }
}
