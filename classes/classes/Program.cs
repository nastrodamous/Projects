using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.carMake = "Honda";
            myNewCar.carModel = "civic";
            myNewCar.carYear = 2015;
            myNewCar.carColor = "Gold";

            Console.WriteLine("{0} - {1} - {2}",
                
                myNewCar.carMake,
                myNewCar.carModel,
                myNewCar.carColor);

           // double marketValueOfCar = determineMarketValue(myNewCar);

            Console.WriteLine("cars value: {0:C}", myNewCar.determineMarketValue());
            Console.ReadLine();

        }
        private static double determineMarketValue(Car car)
        {
            double carValue = 100.00;
                //somebday write code and retrieve value into car value

                return carValue;


        }

    }

    class Car
    {
        public string carMake { get; set; }
        public string carModel{ get; set; }
        public int carYear { get; set; }
        public string carColor { get; set; }

        public double determineMarketValue()
        {
            double carValue = 100.00;
                //somebday write code and retrieve value into car value
            
            if(this.carYear > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;


            return carValue;
        }

    }







}
