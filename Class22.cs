/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // USO DE INTERFACES
    class Class22
    {
        public static void Main(String[] Args)
        {
            Ellipse e1 = new(new ConsoleLogger())
            {
                position = new(20, 30),
                size = new(100, 120)
            };
            e1.Draw();

            // Testing default interface methods
            ILogger logger = new ConsoleLogger();
            logger.Log("message");
            logger.Log(new Exception("sample exception"));
        }
    }
    public record Position(int X, int Y);
    public record Size(int Width, int Height);

    public interface ILogger
    {
        void Log(string message);
        public void Log(Exception ex) => Log(ex.Message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine(message);
        void ILogger.Log(Exception ex)
        {
            Console.WriteLine(
                $"Exception type: {ex.GetType().Name}, message: {ex.Message}");
        }
    }
    public abstract class Shape
    {
        public Shape(ILogger logger)
        {
            Logger = logger;
        }
        protected ILogger Logger { get; }
        public Position? position { get; init; }
        public Size? size { get; init; }
        public void Draw() => DisplayShape();
        protected virtual void DisplayShape()
        {
            Logger.Log($"Shape with {position} and {size}");
        }
    }

    public class Ellipse : Shape
    {
        public Ellipse(ILogger logger) : base(logger) {}
        protected override void DisplayShape()
        {
            Logger.Log($"Ellipse at {position} with Size {size}");
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(ILogger logger) : base(logger) {}
        protected override void DisplayShape()
        {
            Logger.Log($"Rectangle at {position} with Size {size}");
        }
    }
}
*/