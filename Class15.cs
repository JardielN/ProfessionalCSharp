/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class15
    {
        public static void Main(string[] Args)
        {
            // TUPLAS
            void IntroTuples()
            {
                (string AString, int Number, Book Book) tuple1 =
                    ("magic", 42, new Book("Professional C#", "Wrox Press"));
                Console.WriteLine($"a string: {tuple1.AString}, " +
                    $"number: {tuple1.Number}, " +
                     $"book: {tuple1.Book}");
            }
            IntroTuples();
            // the tuple literal can be assigned to a tuple variable without
            // declaring its members
            var tuple2 = ("magic", 42, new Book("Professional C#", "Wrox Press"));
            Console.WriteLine($"a string: {tuple2.Item1}, " +
                    $"number: {tuple2.Item2}, " +
                     $"book: {tuple2.Item3}");

            // Deconstruccion de tuplas. Las tuplas se pueden dividir por variables
            void TuplesDeconstruction()
            {
                var tupla1 = (AString: "magic",
                    Number: 42, Book: new Book("Professional C#", "Wrox Press"));
                (string aString, int number, Book book) = tupla1;
                Console.WriteLine($"a string: {aString}, number: {number}," +
                    $"book{book}");
                (_, _, var book1) = tupla1;
                Console.WriteLine(book1.Title);
            }
            TuplesDeconstruction();

            // Returning tuples
            static (int result, int remainder) Divide(int dividend, int divisor)
            {
                int result = dividend / divisor;
                int remainder = dividend % divisor;
                return (result, remainder);
            }
             static void ReturningTuples()
            {
                (int result, int remainder) = Divide(7, 2);
                Console.WriteLine($"7/2 - result: {result}, remainder: {remainder}");

            }
            ReturningTuples();
        }
       
    }

    public record Book(string Title, string Publisher);
}
*/