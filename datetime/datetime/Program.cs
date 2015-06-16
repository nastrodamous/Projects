using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.ToLongTimeString());


            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

           // Console.WriteLine(myValue.AddHours(3).ToShortTimeString());

           // Console.WriteLine(myValue.AddDays(-3).ToShortDateString());

            ///ConsoleDateTime myBirthday = new DateTime(1989, 3, 24);

            DateTime myBirthday = DateTime.Parse("3/24/1989");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            
            
            
            Console.WriteLine(myBirthday.ToShortDateString());
           

            
            Console.ReadLine();
        }
    }
}
