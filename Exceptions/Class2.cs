/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.Exceptions
{
    class Class2
    {
        static void Main(string[] args)
        {
            static void ThrowErrorWithCode(int code)
            {
                throw new MyCustomException("Error in Foo")
                {
                    ErrorCode = code
                };
            }

            try
            {
                ThrowErrorWithCode(407);
            }
            catch(MyCustomException ex) when (ex.ErrorCode == 405)
            {
                Console.WriteLine($"Exception caught with filter " +
                    $"{ex.Message} " +
                    $"and {ex.ErrorCode}");
            }
            catch(MyCustomException ex)
            {
                Console.WriteLine($"Exception caught {ex.Message}" +
                    $" and {ex.ErrorCode}");
            }
        }
    }

    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message)
        {

        }
        public int ErrorCode { get; set; }
    }
}
*/