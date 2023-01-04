/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.Exceptions
{
    class RethrowExceptions
    {
        static void Main(string[] args)
        {
            // Cuando detecta excepciones, es comun volver a 
            // generar excepciones. Un problema es que el caller
            // necesita averiguar el motivo de lo que sucedio
            // con la excepcion anterior y donde sucedio.
#line 100
// El metodo HandleAll() invoca a todos los metodos
// generadores de excepciones, asi como el seguimiento de pila
// en consola. Y para encontrar mejor a que numeros de linea
// se hace referencia, se usa la directiva de preprocesador
// #line que reinicia la numeracion de linea.
            void HandleAll()
            {
                Action[] methods =
                {
                    HandleAndThrowAgain,
                    HandleAndThrowWithInnerException,
                    HandleAndRethrow,
                    HandleWithFilter
                };

                foreach(var m in methods)
                {
                    try
                    {
                        m(); 
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                        if(ex.InnerException != null)
                        {
                            Console.WriteLine($"\tInner Exception {ex.InnerException.Message}");
                            Console.WriteLine(ex.InnerException.StackTrace);
                        }
                        Console.WriteLine();
                    }
                }
            }
            HandleAll();

#line 8000
// Este metodo lanza la primera excepcion. Es util saber
// donde se lanza esta excepcion.
            static void ThrowAnException(string message)
            {
                throw new MyCustomException(message);
            }

#line 4000
// Este metodo no hace nada mas que registrar la excepcion en
// consola y lanzarla nuevamente usando throw ex.
            static void HandleAndThrowAgain()
            {
                try
                {
                    ThrowAnException("test 1");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Log exception {ex.Message} and throw again");
                }
            }

#line 3000
// Es util cambiar el tipo de excepcion y agregar infomracion
// sobre el error. Para eso es este metodo. Despues de
// registrar el error, se lanza una nueva excepcion de tipo
// AnotherCustomException() para pasar ex como excepcion interna
            static void HandleAndThrowWithInnerException()
            {
                try
                {
                    ThrowAnException("test 2");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Log Exception {ex.Message} and throw again");
                    throw new AnotherCustomException("throw with inner exception", ex); // 3009
                }
            }

#line 2000
// Si no se debe cambiar el tipo de excepcion, se puede
// volver a generar la misma excepcion simplemente con 
// la declaracion throw. 
            static void HandleAndRethrow()
            {
                try
                {
                    ThrowAnException("test 3");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Log exception {ex.Message} and rethrow");
                    throw; // line 2009
                }
            }

#line 1000
            void HandleWithFilter()
            {
                try
                {
                    ThrowAnException("test 4"); // line 1004
                }
                catch(Exception ex) when (Filter(ex))
                {
                    Console.WriteLine("block never invoked");
                }
            }

#line 1500
            bool Filter(Exception ex)
            {
                Console.WriteLine($"just log {ex.Message}");
                return false;
            }
        }
    }

    // crear dos tipos personalizados. El segundo,
    // AnotherCustomException(), permite pasar una excepcion interna
    public class MyCustomException : Exception
    {
        public MyCustomException(string message) 
            : base(message) { }
        public int ErrorCode { get; set; }
    }

    public class AnotherCustomException : Exception
    {
        public AnotherCustomException(string message, 
            Exception innerException) 
            : base(message, innerException) { }
    }
}
*/