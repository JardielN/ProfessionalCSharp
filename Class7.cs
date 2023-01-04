/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class7
    {
        static void Main(string[] args)
        {

        }
    }

    // Constructores

    public class Singleton
    {
        private static Singleton s_instance;
        private int _state;
        private Singleton(int state) => _state = state;

        public static Singleton Instance => s_instance ??= new Singleton(42);
    }

    public class Book
    {
        public string Title { get; }
        public string Publisher { get; }
        public Book(string title, string publisher) =>
            (Title, Publisher) = (title, publisher);
    }

    // Calling constructors from other constructors
    class Car
    {
        private string _description;
        private uint _nWheels;
        public Car(string description, uint nWheels)
        {
            _description = description;
            _nWheels = nWheels;
        }
        public Car(string description) : this(description, 4)
        {

        }
    }
}
*/