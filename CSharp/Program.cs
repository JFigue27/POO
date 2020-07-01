using System;
using CSharp.Entities;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var car = new Car();
            car.id = 1;
            car.driver = "Jaime Figueroa";
            car.license = "JJFI123456";
            car.passenger = 4;
            car.printDataCar();

        }
    }
}
