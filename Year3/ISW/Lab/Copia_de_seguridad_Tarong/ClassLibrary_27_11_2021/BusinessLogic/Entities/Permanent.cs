﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.Entities
{
    public partial class Permanent
    {
        public Permanent() { 
        
        }

        public Permanent(string bankAccount, DateTime initialDate, string SSN, Person hired, double salary) : base(bankAccount, initialDate, SSN, hired)
        {
            this.Salary = salary;
        }

        // Check if the the minimum salary is guaranteed
        public bool CheckSalary()
        {            
            if (this.Salary >= 965) return true;
            else return false;
            
        }
    }
}
