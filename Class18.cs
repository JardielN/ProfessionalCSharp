/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// HERENCIA
namespace CURSOIII
{
    class Class18
    {
        public static void Main(string[] Args)
        {
            Rectangle r1 = new();
            r1.position.X = 33;
            r1.position.Y = 22;
            r1.size.Width = 200;
            r1.size.Height = 100;
            Rectangle r2 = r1.Clone();
            r2.position.X = 300;

            Ellipse e1 = new();
            e1.position.X = 122;
            e1.position.Y = 200;
            e1.size.Width = 40;
            e1.size.Height = 20;

            void DisplayShapes(params Shape[] shapes)
            {
                foreach(var shape in shapes)
                {
                    shape.Draw();
                }
            }
            DisplayShapes(r1, r2, e1);

            r2.Move(new Position {X = 120, Y = 40 });
        }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() => $"X: {X}, Y: {Y}";
    }
    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override string ToString() => $"Width: {Width}, Height: {Height}";
    }

    public class Shape
    {
        public Position position { get; } = new Position();
        public Size size { get; } = new Size();
        protected virtual void DisplayShape()
        {
            Console.WriteLine($"Shape with {position} and {size}");
        }
        public void Draw() => DisplayShape();
        public virtual Shape Clone() => throw new NotImplementedException();
        public virtual void Move(Position newPosition)
        {
            position.X = newPosition.X;
            position.Y = newPosition.Y;
            Console.WriteLine($"moves to {position}");
        }
    }

    public class Rectangle: Shape
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Rectangle at position {position} with size {size}");
        }
        public override Rectangle Clone()
        {
            Rectangle r = new();
            r.position.X = position.X;
            r.position.Y = position.Y;
            r.size.Width = size.Width;
            r.size.Height = size.Height;
            return r;
        }
        // Llamando a metodos de la clase base
        public override void Move(Position newPosition)
        {
            Console.Write("Rectangle ");
            base.Move(newPosition);
        }
    }

    public class Ellipse : Shape
    {
        protected override void DisplayShape()
        {
            Console.WriteLine($"Ellipse at {position} with size {size}");
        }
        public override void Move(Position newPosition)
        {
            Console.WriteLine("Ellipse ");
            base.Move(newPosition);
        }
        public override Ellipse Clone()
        {
            Ellipse e = new();
            e.position.X = position.X;
            e.position.Y = position.Y;
            e.size.Width = size.Width;
            e.size.Height = size.Height;
            return e;
        }
    }
}
*/