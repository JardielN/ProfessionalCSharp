/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.LINQ
{
    class Class2
    {
        static void Main(string[] args)
        {
            void DeferredQuery()
            {
                List<string> names = new()
                {
                    "Nino",
                    "Alberto",
                    "Juan",
                    "Mike",
                    "Phil"
                };
                var namesWithJ = from n in names
                                 where n.StartsWith("J")
                                 orderby n
                                 select n;
                Console.WriteLine("First iteration");
                foreach(string name in namesWithJ)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine();

                names.Add("John");
                names.Add("Jim");
                names.Add("Jack");
                names.Add("Denny");
                Console.WriteLine("Second iteration");
                foreach(string name in namesWithJ)
                {
                    Console.WriteLine(name);
                }
            }
            DeferredQuery();
            Console.WriteLine();

            List<string> names = new() { "Nino", "Alberto", "Juan", "Mike",
            "Phil" };
            var nameswithJ = (from n in names
                              where n.StartsWith("J")
                              orderby n
                              select n).ToList();
            Console.WriteLine("First iteration");
            foreach(string name in nameswithJ)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            names.Add("John");
            names.Add("Jim");
            names.Add("Jack");
            names.Add("Denny");

            Console.WriteLine("Second iteration");
            foreach(string name in nameswithJ)
            {
                Console.WriteLine(name);
            }
        }
    }
}
*/