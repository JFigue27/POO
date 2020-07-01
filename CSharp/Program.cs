using System;
using CSharp.Entities;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var car = new Car("JJFI123456");
            car.driver = "Jaime Figueroa";
            car.passenger = 4;
            car.printDataCar();

        }
    }
}
