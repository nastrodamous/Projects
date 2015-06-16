using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var myValue = superSecretFormula("rockaboy doodle");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            // some sick stuff
            return "Hello World!";
        }

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}", name);
        }
    }
}
