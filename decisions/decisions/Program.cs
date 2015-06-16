using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please type something and press enter");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("you typed: " + userValue);


            Console.WriteLine("would you prefer what is behind door number 1 2 or 3");
            string userValue = Console.ReadLine();
            
            //string message = "";

            //if (userVaule == "1")
            //    message = "you won a car";
            //else if(userVaule == "2")
            //     message = "you suck";
            //else if(userVaule == "3")
            //     message = "you still suck";
            //else
            //    message = "lmao just quit bro";
            //Console.WriteLine(message);    


            string message = (userValue == "1") ? "boat " : "strand of lint";
            Console.WriteLine("you won a {0}", message);
            
            
            Console.ReadLine();

            
        }
    }
}
