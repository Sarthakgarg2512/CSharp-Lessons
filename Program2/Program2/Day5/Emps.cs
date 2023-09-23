using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day5
{
    public class Emps
    {
        public double ID;
        public string Title;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Emps(double v1)
        {
            ID = v1;
        }
        public double GetID()
        {
            return ID;
        }
    }
}

