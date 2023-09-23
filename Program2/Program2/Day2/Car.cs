using Program2.Day2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day2
{
    internal class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int YearOfLaunch { get; set; } 
        public string Type { get; set; } = string.Empty;
        public string Engine { get; set; } = string.Empty;
        public string Colour { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"ID:{this.Id},\n" +
            $"BrandName:{Brand}, Name:{Name}, LaunchYear:{YearOfLaunch},\n" +
            $"Type:{Type}, Engine:{Engine}, Colour:{Colour}";
}


        }

    }

internal class TestCar
{
    public static void TestOne()
    {
        Car newCar = new Car();
        newCar.Id = 1;
        newCar.Brand = "BMW";
        newCar.Name = "7 Series";
        newCar.YearOfLaunch = 2023;
        newCar.Type = "Sedan";
        newCar.Engine = "3.0L";
        newCar.Colour = "Black";
        String value = newCar.ToString();
        Console.WriteLine(value);
    }
}

