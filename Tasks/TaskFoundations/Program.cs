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
    class Program
    {
        void main()
        {
            //CallerWithAsync();
            // CallerWithAwaiter();
            MultipleAsyncMethods();
           // MultipleAsyncMethodsWithCombinators1();
            Thread.Sleep(4000);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.main();
        }

        public static void TraceThreadAndTask(string info)
        {
            // Task.CurrentId devuelve el identificador de la tarea
            string taskInfo = Task.CurrentId == null ? "no task" : "task "
                + Task.CurrentId;
            // Thread.CurrentThread.ManagedThreadId devuelve el identificador
            // del hilo actual.
            Console.WriteLine($"{info} in thread {Thread.CurrentThread.ManagedThreadId} and {taskInfo}");
        }

        // Este metodo tarda un tiempo antes de devolver el string.
        static string Greeting(string name)
        {
            TraceThreadAndTask($"running {nameof(Greeting)}");
            Task.Delay(3000).Wait();
            return $"Hello, {name}";
        }

        // Para crear un metodo asincrono, defina GreetingAsync. 
        // El patron basado en tareas especifica que un metodo asincrono
        // se nombra con el sufijo Async y devuelve Task.GreetingAsync.
        // El metodo defuelve Task<String>, que devuelve una string en el futuro
        // Una forma sencilla de devolver una tarea en este ejemplo seria
        // Task.Run<string>(). Pero el compilador ya sabe que Greeting()
        // devuelve una string, por lo cual aqui se simplifica.
       static Task<string> GreetingAsync(string name) =>
       Task.Run(() =>
       {
           TraceThreadAndTask($"running {nameof(GreetingAsync)}");
           return Greeting(name);
       });

        // Para llamar al metodo asincrono usamos la palabra clave 
        // await en la que la tarea se devuelve. Dicha palabra requiere
        // que el metodo se declare con el modificador async.
        // El codigo dentro de este metodo no continue antes de que se
        // complete el metodo GreetingAsync(). Sin embargo, puede
        // reutilizar el hilo que inicio el metodo CallerWithAsync().
        private static async void CallerWithAsync()
        {
            TraceThreadAndTask($"started {nameof(CallerWithAsync)}");
            string result = await GreetingAsync("Stephanie");
            Console.WriteLine(result);
            TraceThreadAndTask($"ended {nameof(CallerWithAsync)}");
        }

        // Puedes usar la palabra clave async con cualquier objeto que 
        // ofrezca el metodo GetAwaiter() y devuelva un awaiter. Un awaiter
        // implementa la interfaz INotifyCompletion() con el metodo
        // OnCompleted(). Este metodo se invoca cuando se completa la tarea.
        // Con el siguiente metodo, en luar de usar await, se usa el 
        // metodo GetAwaiter() de la tarea. 
        private static void CallerWithAwaiter()
        {
            TraceThreadAndTask($"starting {nameof(CallerWithAwaiter)}");
            TaskAwaiter<string> awaiter = GreetingAsync("Matthias").GetAwaiter();
            awaiter.OnCompleted(OnCompleteAwaiter);

            void OnCompleteAwaiter()
            {
                Console.WriteLine(awaiter.GetResult());
                TraceThreadAndTask($"ended {nameof(CallerWithAwaiter)}");
            }
        }

        // Tambien se pueden hacer ejecuciones mediante el uso de las
        // caracteristicas el objeto Task(). Recuerda que devuelve un objeto
        // Task<string>. El objeto Task() contiene informacion sobre la tarea
        // creada y permite esperar a que se complete. 
        // El metodo ContinueWith de la clase Task define el codigo que sigue
        // despues de que finaliza la tarea. 
        // El delegado asignado recibe la tarea completada con su argumento,
        // lo que permite acceder al resultado de la tarea con la propiedad
        // Result.
        private static void CallerWithContinuationTask()
        {
            TraceThreadAndTask("started CallerWithContinuationTask.");
            var t1 = GreetingAsync("Stephanie");

            t1.ContinueWith(t =>
            {
                string result = t.Result;
                Console.WriteLine(result);

                TraceThreadAndTask("ended CallerWithContinuationTask");
            });
        }


    }
}
*/