using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day2
{
    internal class Person
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; }
        public override string ToString()
        {
            return $"ID:{this.Id}, Name:{Title} {FirstName}{LastName},\n"+
                $"Address:{Address},City:{City} Region:{Region},\n" +
                $"Phone:{Phone}, Country:{Country}, Zip:{PostalCode}";
        }

    }
    internal class TestPerson
    {
        public static void TestOne() 
        {
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.FirstName = "Sarthak";
            firstPerson.LastName = "G";
            firstPerson.Address = "UP";
            firstPerson.City = "Ghaziabad";
            firstPerson.Region = "NCR";
            firstPerson.PostalCode = "201001";
            firstPerson.Country = "India";
            firstPerson.Phone = 9797979797;
            String value=firstPerson.ToString();
            Console.WriteLine(value);


        }
        

    }
}
