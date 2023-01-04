/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // IMPLEMENTING CUSTOM INDEXERS
    class Class28
    {
        public static void Main(String[] Args)
        {
            Person p1 = new("Ayrton", "Senna", new DateTime(1960, 3, 21));
            Person p2 = new("Ronnie", "Peterson", new DateTime(1944, 2, 14));
            Person p3 = new("Jochen", "Rindt", new DateTime(1942, 4, 18));
            Person p4 = new("Francois", "Cevert", new DateTime(1944, 2, 25));
        }
    }

    public record Person(string FirstName, string LastName, DateTime Birthday)
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    public class PersonCollection
    {
        private Person[] _people;
        public PersonCollection(params Person[] people) =>
            _people = people.ToArray();

        public Person this[int index]
        {
            get => _people[index];
            set => _people[index] = value;
        }

        public IEnumerable<Person> this[DateTime birthDay]
        {
            get => _people.Where(p => p.Birthday == birthDay);
        }
    }
}
*/