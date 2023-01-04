/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // MULTICAST DELEGATES
    class Class36
    {
        public static void Main(String[] Args)
        {
            /*
            DoubleOp[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };
            
            // Instead of declaring DoubleOp, you can use
            // the Func<in T, out TResult>
            Action<double> operations = MathOperations.MultiplyByTwo;
            operations += MathOperations.Square;

            // instead of DoubleOp action parameter
           static void ProcessAndDisplayNumber(Action<double> action, double value)
            {
                Console.WriteLine($"ProcessAndDisplayNumber called with: " +
                    $" value = {value}");
                action(value);
                Console.WriteLine();
            }

            ProcessAndDisplayNumber(operations, 2.0);
            ProcessAndDisplayNumber(operations, 7.94);
            ProcessAndDisplayNumber(operations, 1.414);
        }
    }


    public static class MathOperations
    {
        public static void MultiplyByTwo(double value)
            => Console.WriteLine($"Multiplying by 2: {value} " +
                $" gives {value * 2}");
        public static void Square(double value)
            => Console.WriteLine($"Squaring: {value}" +
                $" gives {value * value}");
    }
}
*/