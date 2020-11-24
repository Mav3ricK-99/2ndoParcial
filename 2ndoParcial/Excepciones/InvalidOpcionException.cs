using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class InvalidOpcionException : Exception
    {
        public InvalidOpcionException() : base("Porfavor, ingrese una opcion valida.")
        { 
        }

        public InvalidOpcionException(string exceptionStr) : base(exceptionStr)
        {
        }

        public InvalidOpcionException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
