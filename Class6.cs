/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class6
    {
        static void Main(string[] args)
        {
            // Call static members
            int x = Math.GetSquareOf(5);
            Console.WriteLine($"Square of 5 is {x}");

            // Instantiate a Math object
            Math math = new();

            // Call instance members
            math.Value = 30;
            Console.WriteLine($"Value field of math variable contains {math.Value}");
            Console.WriteLine($"Square of 30 is {math.GetSquare()}");

            // optional arguments
            void TestMethod(int notOptionalNumber, int optionalNumber = 42)
            {
                Console.WriteLine(optionalNumber + notOptionalNumber);
            }

            TestMethod(11);
            TestMethod(11, 42);

            // variable number of arguments
            void AnyNumberOfArguments(params int[] data)
            {
                foreach(var x in data)
                {
                    Console.WriteLine(x);
                }
            }

            AnyNumberOfArguments(1);
            AnyNumberOfArguments(1, 3, 5, 7, 11, 13);

            // If arguments of different types should be passed to methods,
            // you can use an object() array
            void AnyNumberOfArgumentsI(params object[] data)
            {
                foreach(var x in data)
                {
                    Console.WriteLine(x);
                }
            }
            AnyNumberOfArgumentsI("text", 42);
        }
    }

    // METODOS

    public class Math
    {
        public int Value { get; set; }
        public int GetSquare() => Value * Value;
        public static int GetSquareOf(int x) => x * x;
    }

    
}
*/