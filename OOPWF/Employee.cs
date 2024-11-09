using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OOPWF
{
    
    [Serializable]
    public class Employee : Employeebase, Task
    {
        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private DateTime start;
        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

    }
}
