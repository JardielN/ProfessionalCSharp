/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class12
    {
        static void Main(string[] args)
        {
            Book1 book1a = new() { Title = "Professional C#", Publisher = "Wrox Press" };
            Book1 book1b = new() { Title = "Professional C#", Publisher = "Wrox Press" };
            if (!object.ReferenceEquals(book1a, book1b)) Console.WriteLine("Two different " +
                 "references");
            if (book1a == book1b) Console.WriteLine("Both records have the same value");

            var aNewBook = book1a with { Title = "Professional C# and .NET - 2024" };

            Book2 book2 = new("Professional C#", "Wrox Press");
            Console.WriteLine(book2);
        }
    }

    // RECORDS

    // Nomal Record
    public record Book1
    {
        // init-only accessors are used to forbid state changes
        // after an instance has been created
        public string Title { get; init; } = string.Empty;
        public string Publisher { get; init; } = string.Empty;
    }

    // positional record
    public record Book2(string Title, string Publisher);
}
*/