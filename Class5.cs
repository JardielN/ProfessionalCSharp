/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class5
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jardiel", "Ruiz");
            person.Age = 4;
            int age = person.Age;
            Console.WriteLine(person.FullName);

            Book theBook = new("Professional C#")
            {
                Publisher = "Wrox Press"
            };

        }
    }

    // PROPIEDADES (GET / SET)

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        // Propiedades con cuerpo de expresion
        private readonly string _firstName;
        public string FirstName => _firstName;
        private readonly string _lastName;
        public string LastName => _lastName;
        public string FullName => $"{FirstName} {LastName}";

        // Modificadores de acceso a propiedades
        private int _age;
        public int Age
        {
            get => _age;
            set => _age = value;
        }

        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
    }

    public static class PeopleFactory
    {
        private static int s_peopleCount;
    }

    // las propiedades de solo lectura se pueden inicializar desde el constructor
    public class Book
    {
        public Book(string title)
        {
            Title = title;
        }
       public string Title { get; init; }
        public string? Publisher { get; init; }
    }
}
*/