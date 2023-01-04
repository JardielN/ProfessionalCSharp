/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // INTERFACES
    class Class21
    {
        public static void Main(String[] Args)
        {
            Person p1 = new("Jacike", "Stewart");
            Person p2 = new("Graham", "Hill");
            Person p3 = new("Damon", "Hill");
            Person[] people = { p1, p2, p3 };
            Array.Sort(people);
            foreach(var p in people)
            {
                Console.WriteLine(p);
            }
        }
    }

    public record Person(string FirstName, string LastName) : IComparable<Person>
    {
        public int CompareTo(Person? other)
        {
            int compare = LastName.CompareTo(other?.LastName);
            if(compare is 0)
            {
                return FirstName.CompareTo(other?.FirstName);
            }
            return compare;
        }
    }
}
*/