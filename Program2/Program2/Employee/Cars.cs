using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Employee
{
    //    public enum FuelType
    //    {
    //        Petrol,
    //        Diesel

    //    }
    //    public class Car
    //    {
    //        public string RegistrationNumber;
    //        public string Model;
    //        public FuelType FuelType;
    //        public Wheel[] Wheels { get; } = new Wheel[4];
    //        public Engine CarEngine;

    //        public Car(string regNo, string model, FuelType fuelType)
    //        {
    //            RegistrationNumber = regNo;
    //            Model = model;
    //            FuelType = fuelType;

    //            for (int i = 0; i < 4; i++)
    //            {
    //                Wheels[i] = new Wheel();
    //            }

    //            CarEngine = new Engine();
    //        }

    //        public class Wheel
    //        {

    //        }

    //        public class Engine
    //        {

    //        }
    //    }

    //    class car
    //    {
    //        public static void TestA()
    //        {
    //            Car myCar = new Car("UP14CJ2828", "BMW A7", FuelType.Petrol);
    //            Console.WriteLine($"Registration No: {myCar.RegistrationNumber}");
    //            Console.WriteLine($"Model: {myCar.Model}");
    //            Console.WriteLine($"Fuel Type: {myCar.FuelType}");

    //            Console.WriteLine("Wheels:");
    //            foreach (var wheel in myCar.Wheels)
    //            {
    //                Console.WriteLine("Wheel instance");
    //            }
    //            Console.WriteLine("Car Engine:");
    //            Console.WriteLine("Engine instance");
    //        }
    //    }
    //}
public class Car
    {
        // Properties
        public string RegistrationNo { get; set; }
        public string Model { get; set; }
        public FuelType Fuel { get; set; }
        public Wheel[] Wheels { get; set; }
        public Engine CarEngine { get; set; }

        // Constructor
        public Car(string registrationNo, string model, FuelType fuel)
        {
            RegistrationNo = registrationNo;
            Model = model;
            Fuel = fuel;
            Wheels = new Wheel[4];
            CarEngine = new Engine();
        }

        // Enum for FuelType
        public enum FuelType
        {
            Gasoline,
            Diesel,
            Electric,
            Hybrid
        }

        // Inner class for Wheel
        public class Wheel
        {
            public int Size { get; set; }
            public string TireType { get; set; }

            public Wheel(int size, string tireType)
            {
                Size = size;
                TireType = tireType;
            }
        }

        // Inner class for Engine
        public class Engine
        {
            public int Horsepower { get; set; }
            public string Type { get; set; }

            public Engine()
            {
                Horsepower = 150; // Default horsepower
                Type = "Gasoline"; // Default engine type
            }
        }

        // Additional methods and properties can be added as needed
    }

}
