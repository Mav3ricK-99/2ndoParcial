using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class LeerPedidosException : Exception
    {
        public LeerPedidosException() : base("Hubo un Problema al cargar los Pedidos")
        { 
        }

        public LeerPedidosException(string exceptionStr) : base(exceptionStr)
        {
        }

        public LeerPedidosException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
