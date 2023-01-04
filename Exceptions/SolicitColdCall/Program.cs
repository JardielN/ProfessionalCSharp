/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.Exceptions.SolicitColdCall
{
    class Program
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("Please type in the name of the file " +
                "containing the names of the people to be cold called >");
            string? fileName = Console.ReadLine();
            if(fileName != null)
            {
                ColdCallFileReaderLoop1(fileName);
                Console.WriteLine();
            }
            Console.ReadLine();

            void ColdCallFileReaderLoop1(string filename)
            {
                ColdCallFileReader peopleToRing = new();
                try
                {
                    peopleToRing.Open(fileName);
                    for(int i = 0; i < peopleToRing.NPeopleToRing; i++)
                    {
                        peopleToRing.ProcessNextPerson();
                    }
                    Console.WriteLine("All callers processed correctly");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"File file {fileName} does not exist");
                }
                catch(ColdCallFileFormatException ex)
                {
                    Console.WriteLine($"The file {fileName} appears to have been corrupted");
                    Console.WriteLine($"Details of problems are: {ex.Message}");
                    if(ex.InnerException != null)
                    {
                        Console.WriteLine($"Inner exception was: {ex.InnerException.Message}");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Exception occurred:\n{ex.Message}");
                }
                finally
                {
                    peopleToRing.Dispose();
                }
            }
        }
    }
}
*/