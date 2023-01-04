/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.Exceptions.CallerInformation
{
    class Class1
    {
        public static void Main(string[] Args)
        {

            // Llamar al metodo Log() usando una instancia propia
            // dentro del Set() usamos una expresion lambda
            Class1 p = new();
            p.Log();
            p.SomeProperty = 33;
            Action a1 = () => p.Log();
            a1();
        }

        private int _someProperty;
        public int SomeProperty
        {
            get => _someProperty;
            set
            {
                Log();
                _someProperty = value;
            }
        }

        public void Log([CallerLineNumber] int line = -1,
        [CallerFilePath] string path = default,
        [CallerMemberName] string name = default)
        {
            Console.WriteLine($"Line {line}");
            Console.WriteLine(path);
            Console.WriteLine(name);
            Console.WriteLine();
        }
    }
}
*/