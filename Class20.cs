/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // HERENCIA CON RECORDS
    class Class20
    {
        public static void Main(String[] Args)
        {
            Rectangle r1 = new(new Position(33, 22), new Size(200, 100));
            Rectangle r2 = r1 with { position = new Position(100, 22) };
            Ellipse e1 = new(new Position(122, 200), new Size(40, 20));
            void DisplayShapes(params Shape[] shapes)
            {
                foreach(var shape in shapes)
                {
                    shape.Draw();
                }
            }
            DisplayShapes(r1, r2, e1);
        }
    }

    public record Position(int X, int Y);
    public record Size(int Width, int Height);
    public abstract record Shape(Position position, Size size)
    {
        public void Draw() => DisplayShape();
        protected virtual void DisplayShape()
        {
            Console.WriteLine($"Shape with {position} and {size}");
        }
    }
    public record Rectangle(Position position, Size size) : Shape(position, size)
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Rectangle at position {position} with Size {size}");
        }
    }
    public record Ellipse(Position position, Size size) : Shape(position, size)
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Ellipse at position {position} with Size {size}");
        }
    }
}
*/