using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ListaVaciaException : Exception
    {
        public ListaVaciaException() : base("Lista vacia.")
        { 
        }

        public ListaVaciaException(string exceptionStr) : base(exceptionStr)
        {
        }

        public ListaVaciaException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
