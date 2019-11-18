using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    public class EmployeeChangeEventArgs : EventArgs
    {
        private string message = string.Empty;

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
