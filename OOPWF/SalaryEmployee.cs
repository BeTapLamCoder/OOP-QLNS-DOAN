﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OOPWF
{
    [Serializable]
    public class SalaryEmployee: SalaryBase
    {
        public override double TotalSalary()
        {
            double sum;
            if (Dayoff <= 2)
            {
                return sum = Salary + Salary * Increase + Bonus;
            }
            else
            {
                return sum = Salary + Salary * Increase + Bonus - Dayoff * 100;
            }
        }
    }
}
