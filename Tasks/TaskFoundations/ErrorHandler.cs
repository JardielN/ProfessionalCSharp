/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CURSOIII.Tasks.TaskFoundations
{
    class ErrorHandler
    {
        void Main()
        {
            //HandleOnError();
            ShowAggregateException();
            Thread.Sleep(4000);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ErrorHandler p = new ErrorHandler();
            p.Main();
        }

        static async Task ThrowAfter(int ms, string message)
        {
            await Task.Delay(ms);
            throw new Exception(message);
        }

        private static void DontHandle()
        {
            try
            {
               ThrowAfter(200, "first");
                // exception is not caught because this method is finished
                // before the exception is thrown
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async void HandleOnError()
        {
            try
            {
                await ThrowAfter(2000, "first");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"handled {ex.Message}");
            }
        }

        private static async void StartTwoTask()
        {
            try
            {
                await ThrowAfter(2000, "first");
                await ThrowAfter(1000, "second"); // The second call is not invoked
                // an exception
            }
            catch(Exception ex)
            {
                Console.WriteLine($"handled {ex.Message}");
            }
        }

        private async static void StartTwoTasksInParallel()
        {
            try
            {
                Task t1 = ThrowAfter(2000, "first");
                Task t2 = ThrowAfter(1000, "second");
                await Task.WhenAll(t1, t2);
            }
            catch(Exception ex)
            {
                // Just display the exception information of the first task
                // that is awaited within whenAll
                Console.WriteLine($"handled {ex.Message}");
            }
        }

        private static async void ShowAggregateException()
        {
            Task taskResult = null;
            try
            {
                Task t1 = ThrowAfter(2000, "first");
                Task t2 = ThrowAfter(1000, "second");
                await (taskResult = Task.WhenAll(t1, t2));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"handled {ex.Message}");
                foreach(var ex1 in taskResult.Exception.InnerExceptions)
                {
                    Console.WriteLine($"Inner Exception {ex1.Message}");
                }
            }
        }
    }
}
*/