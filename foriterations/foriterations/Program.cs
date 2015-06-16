using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foriterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string zig = "you can get what you out of life" +
                "if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);
            Console.ReadLine();




        }
    }
}
