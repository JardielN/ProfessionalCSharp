
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class8
    {
        // Funciones Locales
        public static void IntroLocalFunctions()
        {
            static int Add(int x, int y) => x + y;
            int result = Add(3, 7);
            Console.WriteLine($"called the local function with this result: {result}");
        }

        public static void LocalFunctionWithClosure()
        {
            int z = 3;
            int result = Add(1, 2);
            Console.WriteLine($"called the local function with this result: {result}");
            int Add(int x, int y) => x + y + z;
        }

        // METODOS GENERIC
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"The output is: {x} and {y}");
        }
    }

   
}
