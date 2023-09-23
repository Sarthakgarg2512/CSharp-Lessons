using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.MyLearning
{
    class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("Invokes");
        }
        public static void DefaultC()
        {
            Constructor c=new Constructor();
        }
    }
    class Constructor2
    {
        int Id;
        string Name;
        int Age;
        public Constructor2(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public int getId() { return Id; }
        public string getName() { return Name; }
        public int getAge() { return Age; } 
        public static void Parameterc()
        {
            Constructor2 c = new Constructor2(1, "Sarthak", 20);

            Console.WriteLine($"Id of person is: {c.getId()}" );

        }

    }
}
