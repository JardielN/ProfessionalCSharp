using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CURSOIII.Tasks.TaskCancellation
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            CancellationTokenSource cancellation = new(TimeSpan.FromSeconds(5));

            // Para cancelar operaciones asincronicas, .NET incluye un framework
            // de cancelacion llamado CancellationToken, que se crea a partir
            // de un CancellationTokenSource() definido en system.Threading.
            // RunTaskAsync() recibe un CancellationToken con un parametro. 
            // En la implementation, el token cancellation se verifica si se
            // solicita una cancelacion. Si es asi, la tarea tiene tiempo para
            // la limpieza de algunos recursos y finaliza activando el metodo
            // ThrowIfCancellationRequested de CancellationToken. 
            Task RunTaskAsync(CancellationToken cancellationToken) =>
                Task.Run(async () =>
                {
                    while (true)
                    {
                        Console.WriteLine(".");
                        await Task.Delay(100);
                        if (cancellationToken.IsCancellationRequested)
                        {
                            // do some cleanup
                            Console.WriteLine("resource cleanup and good bye");
                            cancellationToken.ThrowIfCancellationRequested();
                        }
                    }
                });

            try
            {
                // Cuando inicia un metodo RunTaskAsync, se crea un 
                // CancellationTokenResource que pasa un TimeSpan al constructor
                // y cancela el token asociado despues del tiempo especificado.
                await RunTaskAsync(cancellation.Token);
            }
            catch(OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
