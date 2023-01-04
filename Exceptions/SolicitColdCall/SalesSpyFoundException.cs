using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.Exceptions.SolicitColdCall
{
    class SalesSpyFoundException : Exception
    {
        public SalesSpyFoundException(string spyName)
            :base($"Sales spy found, with name {spyName}") { }

        public SalesSpyFoundException(string spyName, Exception innerException)
            :base($"Sales spy found with name {spyName}", innerException) { }
    }
}
