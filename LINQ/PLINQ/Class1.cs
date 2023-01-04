/*
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.LINQ.PLINQ
{
    class Class1
    {
        static void Main(string[] args)
        {
            static IEnumerable<int> SampleData()
            {
                const int arraySize = 500_00_000;
                var r = new Random();
                return Enumerable.Range(0, arraySize).Select(x => r.Next(140)).ToList();
            }

            static void LinqQuery(IEnumerable<int> data)
            {
                Console.WriteLine(nameof(LinqQuery));
                var res = (from x in data.AsParallel()
                           where Math.Log(x) < 4
                           select x).Average();
                Console.WriteLine($"result from {nameof(LinqQuery)}: {res}");
                Console.WriteLine();
            }
            LinqQuery(SampleData());
            Console.WriteLine();

            static void ExtensionMethods(IEnumerable<int> data)
            {
                Console.WriteLine(nameof(ExtensionMethods));
                Stopwatch stopwatch = new();
                stopwatch.Start();

                var res = data.AsParallel()
                    .Where(x => Math.Log(x) < 4)
                    .Select(x => x).Average();
                stopwatch.Stop();
                Console.WriteLine($"result from {nameof(ExtensionMethods)}: {res}");
                Console.WriteLine();
            }
            ExtensionMethods(SampleData());
            Console.WriteLine();
        }
    }
}
*/