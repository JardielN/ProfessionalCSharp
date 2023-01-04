/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class3
    {
        static void Main(string[] args)
        {
            UsingStringBuilder();
            UsingFormattableString();
            UseStringFormat();
            RangesWithSrings();

            // StringBuilder - permite una cadena mutable con metodos
            void UsingStringBuilder()
            {
                StringBuilder sb = new("the quick");
                sb.Append(' ');
                sb.Append("brown fox jumped over ");
                sb.Append("the lazy dogs 123456789 times");
                string s = sb.ToString();
                Console.WriteLine(s);
            }

            // FormattableString - permite asignar a tipos que no sean string
            void UsingFormattableString()
            {
                int x = 3, y = 4;
                FormattableString s = $"The result of {x} + {y} is {x + y}";
                Console.WriteLine($"format: {s.Format}");
                for(int i=0; i <s.ArgumentCount; i++)
                {
                    Console.WriteLine($"argument: {i}: {s.GetArgument(i)}");
                }
                Console.WriteLine();
            }

            void UseStringFormat()
            {
                DateTime day = new(1998, 10, 1);
                Console.WriteLine($"{day:D}");
                Console.WriteLine($"{day:d}");

                int i = 2477;
                Console.WriteLine($"{i:n} {i:e} {i:x} {i:c}");

                double d = 3.1415;
                Console.WriteLine($"{d:###.###}");
                Console.WriteLine($"{d:000.000}");
                Console.WriteLine("\n");
            }

            void RangesWithSrings()
            {
                string s = "The quick brown fox jumpd over the lazy dogs down "
                    + "123456789 times";
                string the = s[..3];
                string quick = s[4..9];
                string times = s[^5..^0];
                Console.WriteLine(the);
                Console.WriteLine(quick);
                Console.WriteLine(times);
            }
        }
    }
}
*/