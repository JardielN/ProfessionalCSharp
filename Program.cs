/*
using System;

namespace CURSOIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Title = "Professional C#";
            Console.WriteLine(b1);
            SwitchSample(2);
            PatternMatching(b1);
            var light = TrafficLight.Red;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(light);
                light = NextLight(light);
            }



            void PatternMatching(object o)
            {
                if (o is null) throw new ArgumentNullException(nameof(o));
                else if(o is Book b)
                {
                    Console.WriteLine($"received a book: {b.Title}");
                }
            }

            void SwitchSample(int x)
            {
                switch (x)
                {
                    case 1:
                        Console.WriteLine("IntegerA = 1");
                        break;
                    case 2:
                        Console.WriteLine("integerA = 2");
                        break;
                    case 3:
                        Console.WriteLine("integerA = 3");
                        break;
                    default:
                        Console.WriteLine("integerA is not 1, 2 or 3");
                        break;
                }
            }
           
        TrafficLight NextLight(TrafficLight light)
            {
                switch (light)
                {
                    case TrafficLight.Green:
                        return TrafficLight.Amber;
                    case TrafficLight.Amber:
                        return TrafficLight.Red;
                    case TrafficLight.Red:
                        return TrafficLight.Green;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public override string ToString() => Title;
    }

    enum TrafficLight
    {
        Red,
        Amber,
        Green
    }

}
*/