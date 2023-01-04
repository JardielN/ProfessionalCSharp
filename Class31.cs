/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // CREANDO ARRAYS USANDO LA CLASE ARRAY
    class Class31
    {
        public static void Main(String[] Args)
        {
            Array intArray1 = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < 5; i++)
            {
                intArray1.SetValue(3 * i, i);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray1.GetValue(i));
            }

            int[] lengths = { 2, 3 };
            int[] lowerBounds = { 1, 10 };
            Array racers = Array.CreateInstance(typeof(Person), lengths, lowerBounds);
            racers.SetValue(new Person("Alain", "Prost"), 1, 10);
            racers.SetValue(new Person("Emerson", "Fittipaldi"), 1, 11);
            racers.SetValue(new Person("Ayrton", "Senna"), 1, 12);
            racers.SetValue(new Person("Michael", "Schumacher"), 2, 10);
            racers.SetValue(new Person("Fernando", "Alonso"), 2, 11);
            racers.SetValue(new Person("Jenson", "Button"), 2, 12);

            // Array.Sort
            string[] names =
            {
                "Lady Gaga",
                "Shakira",
                "Beyonce",
                "Ava Max"
            };
            Array.Sort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            // Sorting an array of Person() objects by the last name
            // implementing IComparable<Person>
            Person[] persons =
            {
                new("Damon", "Hill"),
                new("Niki", "Lauda"),
                new("Ayrton", "Senna"),
                new("Graham", "Hill")
            };
            Array.Sort(persons);
            foreach (var p in persons)
            {
                Console.WriteLine(p);
            }

            // Implementing IComparer<Person>
            Array.Sort(persons, new PersonComparer(PersonCompareType.FirstName));
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }

            // Passing Arrays as parameters
            static Person[] GetPersons() =>
            new Person[] {
            new Person("Damon", "Hill"),
            new Person("Niki", "Lauda"),
            new Person("Ayrton", "Senna"),
            new Person("Graham", "Hill")
            };
        }
    }

    public record Person(string FirstName, string LastName) : IComparable<Person>
    {
        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            int result = string.Compare(this.LastName, other.LastName);
            if(result == 0)
            {
                result = string.Compare(this.FirstName, other.FirstName);
            }
            return result;
        }
    }

    // Implemented your own Sorting method.
    public enum PersonCompareType
    {
        FirstName,
        LastName
    }
    public class PersonComparer : IComparer<Person>
    {
        private PersonCompareType _compareType;
        public PersonComparer(PersonCompareType compareType)
            => _compareType = compareType;
        public int Compare(Person? x, Person y)
        {
            if (x is null && y is null) return 0;
            if (x is null) return 1;
            if (y is null) return -1;

            return _compareType switch
            {
                PersonCompareType.FirstName
                => x.FirstName.CompareTo(y.FirstName),
                PersonCompareType.LastName
                => x.LastName.CompareTo(y.LastName),
                _=> throw new ArgumentException("unexpected compare type")
            };
        }
    }
}
*/