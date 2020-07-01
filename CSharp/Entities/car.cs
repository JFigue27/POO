using System;

namespace CSharp.Entities
{
    public class Car
    {
        public Car(String license)
        {
            this.license = license;
        }


        public int id { get; set; }
        public string license { get; set; }
        public string driver { get; set; }
        public int passenger { get; set; }


        public void printDataCar()
        {
            Console.WriteLine("License " + license + " Driver " + driver);
        }

    }
}