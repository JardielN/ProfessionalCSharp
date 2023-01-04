/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a String");
            string? input = Console.ReadLine(); // String es nulo por defecto

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("You typed in an empty string.");
            }
            else if(input?.Length < 5)
            {
                Console.WriteLine("The string had less than 5 characters");
            }
            else
            {
                Console.WriteLine("Read any other string");
            }
            Console.WriteLine("The string was " + input);
        }
    }
}
*/