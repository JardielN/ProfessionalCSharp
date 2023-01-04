/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class13
    {
        static void Main(string[] args)
        {
            Dimensions point = new(3, 2);
            Console.WriteLine(point);

            void ColorSamples()
            {
                Color c1 = Color.Red;
                Console.WriteLine(c1);
                Color c2 = Color.Green;
                Console.WriteLine(c2);
                Color c3 = Color.Blue;
                Console.WriteLine(c3);
            }
            ColorSamples();
        }
    }

    // STRUCTS
    // Si el estado no cambia, se puede definir como readonly
    public readonly struct Dimensions
    {
        public Dimensions(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; }
        public double Width { get; }

        public double Diagonal => Math.Sqrt(Length * Length + Width * Width);
        public override string ToString()
        {
            return $"Length: {Length}, Width: {Width}";
        }
    }

    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public enum ColorS : short
    {
        Red = 1,
        Green = 2,
        Blue = 3
    }
}
*/