using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
   public static class Class10
    {
        // EXTENSION METHODS
        // Siempre deben estar en una clase estatica
        public static int GetWordCount(this string s) => s.Split().Length;
    }
}
