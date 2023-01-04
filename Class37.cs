/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // LAMBDA EXPRESSIONS
    class Class37
    {
        public static void Main(String[] Args)
        {
            // First example
            string mid = ", middle part,";
            Func<string, string> lambda = param =>
            {
                param += mid;
                param += " and this was added to the string.";
                return param;
            };
            Console.WriteLine(lambda("Start of string"));

            // Second example
            Func<string, string> oneParam = s
                => $"change uppercase {s.ToUpper()}";
            Console.WriteLine(oneParam("test"));

            // third example.
            // if the delegate uses more than one parameter
            // you can combine the parameter names inside brackets
            Func<double, double, double> twoParams = (x, y)
                => x * y;
            Console.WriteLine(twoParams(3, 2));

            // Closures
            int someVal = 5;
            Func<int, int> f = x => x + someVal;
            someVal = 7;
            Console.WriteLine(f(3));
        }
    }
}
*/