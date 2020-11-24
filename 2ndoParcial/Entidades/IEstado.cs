using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IEstado
    {
        EEstadoPedido EstadoPedido { get; set; }
    }
}
