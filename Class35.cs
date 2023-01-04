/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // PASSING DELEGATES TO METHODS
    class Class35
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
            Func<double, double>[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };

            // instead of DoubleOp action parameter
            void ProcessAndDisplayNumber(Func<double, double> action, double value)
            {
                double result = action(value);
                Console.WriteLine($"Value is {value}," +
                    $"result of operation is {result}");
            }

            for(int i=0; i< operations.Length; i++)
            {
                Console.WriteLine($"Using operations[{i}]");
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
            }
        }
    }

    public delegate double DoubleOp(double x);

    public static class MathOperations
    {
        public static double MultiplyByTwo(double value)
            => value * 2;
        public static double Square(double value)
            => value * value;
    }
}
*/