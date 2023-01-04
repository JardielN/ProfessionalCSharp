/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CLASES ABSTRACTAS Y METODOS
namespace CURSOIII
{
    class Class19
    {
        public static void Main(String[] Args)
        {
           
        }
    }

    public class Position
    {
        public Position(int x, int y) => (X, Y) = (x, y);

        public int X { get; }
        public int Y { get; }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
    public class Size
    {
        public Size(int width, int height) => (Width, Height) = (width, height);
        public int Width { get; }
        public int Height { get; }
        public override string ToString()
        {
            return $"Widht: {Width}, Height: {Height}";
        }
    }
    public abstract class Shape
    {
        public Shape(int x, int y, int width, int height)
        {
            position = new Position(x, y);
            size = new Size(width, height);
        }
        public Position position { get; }
        public virtual Size size { get; }
        protected virtual void DisplayShape()
        {
            Console.WriteLine($"Shape with {position} and {size}");
        }
        public void Draw() => DisplayShape();
        public abstract Shape Clone();
    }
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height)
            : base(x, y, width, height) { }
        public override Rectangle Clone()
            => new(position.X, position.Y, size.Width, size.Height);
        protected override void DisplayShape()
        {
            Console.WriteLine($"Rectangle at position {position} with size {size}");
        }
    }

    public class Ellipse : Shape
    {
        public Ellipse(int x, int y, int width, int height)
            : base(x, y, width, height) { }
        public override Ellipse Clone()
            => new(position.X, position.Y, size.Width, size.Height);
        protected override void DisplayShape()
        {
            Console.WriteLine($"Ellipse at position {position} with size {size}");
        }
    }
}
*/