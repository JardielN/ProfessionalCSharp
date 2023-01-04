/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // ARRAYS
    class Class30
    {
        public static void Main(String[] Args)
        {
            Person[] myPersons = new Person[2];
            myPersons[0] = new("Ayrton", "Senna");
            myPersons[1] = new("Michael", "Schumacher");
            Person[] myPersons2 =
            {
                new("Ayrton", "Senna"),
                new("Michael", "Schumacher")
            };

            int[,] twodim =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            foreach(var val in twodim)
            {
                Console.WriteLine(val);            }
            }

        // jagged arrays
        int[][] jagged =
        {
         new[] { 1, 2 },
         new[] { 3, 4, 5, 6, 7, 8 },
         new[] { 9, 10, 11 }
        };
    }

    // Using Reference Types
    public record Person(string FirstName, string LastName);
}
*/