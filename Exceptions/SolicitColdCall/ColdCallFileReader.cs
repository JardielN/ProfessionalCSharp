using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.Exceptions.SolicitColdCall
{
    class ColdCallFileReader : IDisposable
    {
        /*
         * Las clases base de Sysem.IO para leer el archivo. 
         * FileStream permite conectarse al archivo en primer lugar
         * StreamReader lee archivos de text e implementa el metodo ReadLine.
         */
        private FileStream? _fileStream;
        private StreamReader? _streamReader;
        private uint _nPeopleToRing;
        /*
         * _isDisposed indica si se ha llamado al metodo Dispose(). Ya que
         * despues de llamarlo, no se permite reabrir conexiones ni reutilizar
         * obejtos.
         */
        private bool _isDisposed = false;
        /*
         * Verifica si StreamReader realmente esta conectado a un archivo abierto
         */
        private bool _isOpen = false;

        /*
         * El proceso de abrir el archivo y leer la primera linea, la que
         * dice cuantas personas hay en el archivo, lo maneja el metodo Open()
         */
        public void Open(string fileName)
        {
            /*
             * Verifica si el cliente llamo al codigo de manera inapropiada 
             * despues de que el objeto se elimino, y de ser asi, llama
             * a ObjectDisposedException.
             */
            if (_isDisposed)
            {
                throw new ObjectDisposedException(nameof(ColdCallFileReader));
            }

            _fileStream = new(fileName, FileMode.Open);
            _streamReader = new(_fileStream);

            try
            {
                string? firstLine = _streamReader.ReadLine();
                if(firstLine != null)
                {
                    _nPeopleToRing = uint.Parse(firstLine);
                    _isOpen = true;
                }
            }
            catch(FormatException ex)
            {
                throw new ColdCallFileFormatException(
                    $"First line isn't an integer{ex}");
            }
        }


        public void ProcessNextPerson()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(nameof(ColdCallFileReader));
            }
            if (!_isOpen)
            {
                throw new UnexpectedException(
                    "Attempted to access coldcall file that is not open");
            }
            try
            {
                string? name = _streamReader?.ReadLine();
                /*
                 * Pueden ocurrir dos problemas. El primero es cuando se devuelve nulo
                 * si ha pasado el final del archivo, debido a que contiene el numero
                 * de nombres al principio del archivo.
                 */
                if (name is null)
                {
                    throw new ColdCallFileFormatException("Not enough names");
                }
                if(name[0] is 'B')
                {
                    throw new SalesSpyFoundException(name);
                }
                Console.WriteLine(name);
            }
            catch(SalesSpyFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }

        /*
         * Devuelve la cantidad de personas que se supone debe haber en el archivo.
         * 
         */
        public uint NPeopleToRing
        {
            get
            {
                if (_isDisposed)
                {
                    throw new ObjectDisposedException("PeopleToRing");
                }
                if (!_isOpen)
                {
                    throw new UnexpectedException(
                        "Attempted to access cold-call file that is not open");
                }
                return _nPeopleToRing;
            }
        }
        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }
            _isDisposed = true;
            _isOpen = false;

            _streamReader?.Dispose();
            _streamReader = null;
        }
    }
}
