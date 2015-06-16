using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive";
            //string myString = "My \"So called \"life";
            //string myString = "What if I need a new \nline";
            //string myString = string.Format("{0}!", "hurray");

            //string myString = string.Format("Make: {0} (Mode {1})", "HONDA", "CIVIC");

            //string myString = string.Format("{0:C}", 123.45);

            //string myString = string.Format("{0:N}",12312313213);

            //string myString = string.Format("phone number:{0:(###) ###-####}", 6784699493);
            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();
            }
            */
            /*
            StringBuilder mystring = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                mystring.Append("--");
                mystring.Append(i);

            }
             * 
             */

            string myString = " lifes a bitch then u die thats why we get high cuz you neve rknow when you gonna go  ";
            //myString = myString.Substring(5, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ","--");

            myString = String.Format("Length before:{0} -- After{1}",
                        myString.Length, myString.Trim().Length);
            Console.WriteLine(myString);
            Console.ReadLine();




        }
    }
}
