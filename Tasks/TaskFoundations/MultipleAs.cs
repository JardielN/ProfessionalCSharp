/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CURSOIII.Tasks.TaskFoundations
{
    class MultipleAs
    {
        void Main()
        {
            //MultipleAsyncMethodsWithCombinators1();
            //MultipleAsyncMethodsWithCombinators2();
            UseValueTasks();
            //GreetingValueTask2Async("Karina");
            Thread.Sleep(4000);
        }
     
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultipleAs p = new MultipleAs();
            p.Main();
        }

        public static void TraceThreadAndTask(string info)
        {
            string taskInfo = Task.CurrentId == null ? "no task" : "task "
                + Task.CurrentId;
            Console.WriteLine($"{info} in thread {Thread.CurrentThread.ManagedThreadId} and {taskInfo}");
        }

        static string Greeting(string name)
        {
            TraceThreadAndTask($"running {nameof(Greeting)}");
            Task.Delay(3000).Wait();
            return $"Hello, {name}";
        }

        static Task<string> GreetingAsync(string name) =>
        Task.Run(() =>
        {
            TraceThreadAndTask($"running {nameof(GreetingAsync)}");
            return Greeting(name);
        });

        // Un combinador acepta multiples parametros del mismo tipo y
        // devuelve un valor del mismo tipo. En este metodo los parametros
        // pasados se "combinan" en uno. Este codigo invoca el metodo combinador
        // Task.WhenAll que puede usarse para ambas tareas.
        private async static void MultipleAsyncMethodsWithCombinators1()
        {
            Task<string> t1 = GreetingAsync("Stephanie");
            Task<string> t2 = GreetingAsync("Matthias");
            await Task.WhenAll(t1, t2);
            Console.WriteLine($"Finished both methods.{Environment.NewLine} " +
            $"Result 1: {t1.Result}{Environment.NewLine} Result 2: {t2.Result}");
        }

        // Debido a que GreetinAsync devuelve Task<String>, y la espera de
        // este metodo resulta en una string. Puedes convertir la devolucion
        // en un array.
        private async static void MultipleAsyncMethodsWithCombinators2()
        {
            Task<string> t1 = GreetingAsync("Stephanie");
            Task<string> t2 = GreetingAsync("Matthias");
            string[] result = await Task.WhenAll(t1, t2);
            Console.WriteLine($"Finished both methods. {Environment.NewLine} " +
                $"Result 1: {result[0]} {Environment.NewLine} Result 2: {result[1]}");
        }

        // USO DE VALUETASKS
        private readonly static Dictionary<string, string> names = new Dictionary<string, string>();

        //Si el nombre ya se encuentra en el diccionario, el resultado se
        // devuelve con ValueTask. Si no esta en el diccionario, se invoca
        // el metodo GreetingAsync, que devuelve Task(). Se espera la tarea.
        // El resultado recibido se utiliza para devolverlo en una ValueTask.
        static async ValueTask<string> GreetingValueTaskAsync(string name)
        {
            if(names.TryGetValue(name, out string result))
            {
                return result;
            }
            else
            {
                result = await GreetingAsync(name);
                names.Add(name, result);
                return result;
            }
        }

        // El metodo UseValueTask() invoca el metodo GreetingValueTaskAsync() dos
        // veces con el mismo nombre. La primera vez, los datos se recuperan 
        // mediante el metodo GreetingAsync; la segunda vez, los datos ya se
        // encuentran en el diccionario y se devuelven desde alli:
        private static async void UseValueTasks()
        {
            string result = await GreetingValueTaskAsync("Katharina");
            Console.WriteLine(result);
            string result2 = await GreetingValueTaskAsync("Katharina");
            Console.WriteLine(result2);
        }

        // Si un metodo no usa el modificador async y se necesita devolver
        // un ValueTask, se puede crear un objeto ValueTask usando el
        // constructor y pasando el resultado a un objeto Task
        static ValueTask<string> GreetingValueTask2Async(string name)
        {
            if(names.TryGetValue(name, out string result))
            {
                return new ValueTask<string>(result);
            }
            else
            {
                Task<string> t1 = GreetingAsync(name);
                TaskAwaiter<string> awaiter = t1.GetAwaiter();
                awaiter.OnCompleted(OnCompletion);
                return new ValueTask<string>(t1);

                void OnCompletion()
                {
                    names.Add(name, awaiter.GetResult());
                }
            }
        }

    }
}
*/