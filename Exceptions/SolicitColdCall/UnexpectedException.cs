using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.Exceptions.SolicitColdCall
{
    class UnexpectedException : Exception
    {
        public UnexpectedException(string message)
            : base(message) { }

        public UnexpectedException(string message, Exception innerException)
            :base(message, innerException) { }
    }
}
