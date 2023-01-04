/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // COMPARING OBJECTS FOR EQUALITY
    class Class27
    {
        public static void Main(String[] Args)
        {
            Book book1 = new("Professional C#", "Wrox Press");
            Book book2 = new("Professional C#", "Wrox Press");

            if(!object.ReferenceEquals(book1, book2))
            {
                Console.WriteLine("Not the same reference");
            }
            if (book1.Equals(book2))
            {
                Console.WriteLine("The same object using the generic Equals method");
            }
            object book3 = book2;
            if (book1.Equals(book3))
            {
                Console.WriteLine("The same object using the overridden Equals method");
            }
            if(book1 == book2)
            {
                Console.WriteLine("The same book using the == operator");
            }
        }
    }

    class Book : IEquatable<Book>
    {
        public Book(string title, string publisher)
        {
            Title = title;
            Publisher = publisher;
        }
        protected virtual Type EqualityContract { get; } =
            typeof(Book);
        public override string ToString()
        {
            return Title;
        }
        public override int GetHashCode()
        {
            return Title.GetHashCode() ^ Publisher.GetHashCode();
        }
        public virtual bool Equals(Book? other) =>
            this == other;
        public static bool operator ==(Book? left, Book? right) =>
            left?.Title == right?.Title && left?.Publisher == right.Publisher &&
            left?.EqualityContract == right?.EqualityContract;
        public static bool operator !=(Book? left, Book? right) =>
            !(left == right);
        public string Title { get; }
        public string Publisher { get; }
        public override bool Equals(object obj)
        {
            return this == obj as Book;
        }
    }
}
*/