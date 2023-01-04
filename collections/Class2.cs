/*
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.collections
{
    class Class2
    {
        static async Task Main(string[] args)
        {
            DocumentManager dm = new();
            Task processDocuments = ProcessDocuments.StartAsync(dm);

            // Create documents and add them to the DocumentManager
            Random random = new();
            for (int i = 0; i < 50; i++)
            {
                var doc = new Document($"Doc {i}", "Content");
                int queueSize = dm.AddDocument(doc);
                Console.WriteLine($"Added document {doc.Title}, " +
                    $" queue Size: {queueSize}");
                await Task.Delay(random.Next(20));
            }
            Console.WriteLine($"Finished adding documents");
            await processDocuments;
            Console.WriteLine("bye!");
        }
    }

    public record Document(string Title, string Content);

    public class DocumentManager
    {
        private readonly object _syncQueue = new object();
        private readonly Queue<Document> _documentQueue = new();

        // devuelve el numero de elements en la cola 
        // para permitir el calculo de su tamano
        public int AddDocument(Document doc)
        {
            // Agregar documento al final de la cola
            // Dado que varias tareas pueden accesar a la clase
            // el acceso a la cola se bloquea con la instruccion lock.
            lock (_syncQueue)
            {
                _documentQueue.Enqueue(doc);
                return _documentQueue.Count;
            }
        }

        public Document GetDocument()
        {
            // Leer documento
            Document doc = null;
            lock (_syncQueue)
            {
                doc = _documentQueue.Dequeue();
            }
            return doc;
        }

        public bool IsDocumentAvailable => _documentQueue.Count > 0;
    }

    // procesa documentos de la cola en una tarea separada
    public class ProcessDocuments
    {
        public static Task StartAsync(DocumentManager dm) =>
            Task.Run(new ProcessDocuments(dm).RunAsync);

        protected ProcessDocuments(DocumentManager dm) =>
            _documentManager = dm ?? throw new ArgumentNullException(nameof(dm));

        private readonly DocumentManager _documentManager;

        protected async Task RunAsync()
        {
            Random random = new();
            Stopwatch stopwatch = new();
            stopwatch.Start();
            bool stop = false;
            do
            {
                // si la tarea toma mas de 5 segundos.
                // el procesamiento se detiene
                if (stopwatch.Elapsed >= TimeSpan.FromSeconds(5))
                {
                    stop = true;
                }
                // La propiedad IsDocumentAvailable
                // se usa para determinar si hay
                // un nuevo documento en la cola
                if (_documentManager.IsDocumentAvailable)
                {
                    stopwatch.Restart();
                    Document doc = _documentManager.GetDocument();
                    Console.WriteLine($"Processing document {doc.Title}");
                }
                // wait a random time before processing the next document
                await Task.Delay(random.Next(20));
            } while (!stop);
            Console.WriteLine("stopped reading documents");
        }
    }
}
*/