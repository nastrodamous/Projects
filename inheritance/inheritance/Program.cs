using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2015;

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = " Ford";
            myTruck.Model = "f950";
            myTruck.Year = 2006;
            myTruck.Color = "red";
            myTruck.towingCapacity = 1200;

            printVehicleDetails(myTruck);



            Console.ReadLine();

        }
        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("here are the Vehicle details: {0}",
                vehicle.FormatMe());




        }
    }

    abstract class Vehicle
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();


    }


    class Car : Vehicle
    {
        
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                   this.Make,
                   this.Model,
                   this.Color,
                   this.Year);

        }



    }

    class Truck : Vehicle
    {
        public int towingCapacity { get; set; }
        
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2}  Towing Units",
                   this.Make,
                   this.Model,
                   this.towingCapacity);

        }
    }
}
