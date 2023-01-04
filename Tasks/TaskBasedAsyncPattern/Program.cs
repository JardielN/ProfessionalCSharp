/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

// Patron ASYNC Basado en Tareas
namespace CURSOIII.Tasks.TaskBasedAsyncPattern
{
    class Program
    {
      public static async Task Main(String[] args)
        {
            // Se utiliza para pedir un argumento de linea de 
            // comandos o pedirla al usuario por la interfaz
            string uri = (args.Length >= 1) ? args[0] : string.Empty;
            if (string.IsNullOrEmpty(uri))
            {
                Console.WriteLine("enter an URL (e.g. https://cshasp.cristianannagel.com)");
                uri = Console.ReadLine() ?? throw new InvalidOperationException();
            }
            // La clase HttpClient implementa este patron.
            using HttpClient httpClient = new();
            try
            {
                // HttpResponseMessage tiene una propiedad IsSuccessStatusCode
                // que se usa para verificar si la respues de servicio
                // fue exitosa.
                using HttpResponseMessage response = await httpClient.GetAsync(new Uri(uri));
                if (response.IsSuccessStatusCode)
                {
                    string html = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(html[..200]);
                }
                else
                {
                    Console.WriteLine($"Status code: {response.StatusCode}");
                }
            }
            catch(UriFormatException ex)
            {
                Console.WriteLine($"Error parsing the Uri {ex.Message}");
            }
            catch(HttpRequestException ex)
            {
                Console.WriteLine($"Http request exception: {ex.Message}");
            }
            catch(TaskCanceledException ex)
            {
                Console.WriteLine($"Task canceled: {ex.Message}");
            }
        }
    }
}
*/