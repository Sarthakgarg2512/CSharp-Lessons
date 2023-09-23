using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day8
{
    [Serializable]
    class Customer
    {
        private readonly double Id;
        public string Title;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int CreditLimit { get; set; }
        public Customer(double v1) { Id = v1; }
        public double GetID() { return Id; }
        public override string ToString()
        {
            return $"Details: {Id} {FirstName} {MiddleName} {LastName} {CreditLimit}";    
        }
    }
}
