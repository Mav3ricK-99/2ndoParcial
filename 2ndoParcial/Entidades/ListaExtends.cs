using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Excepciones;
using Entidades;

namespace System.Collections.Generic
{
    public static class ListaExtends
    {
        public static bool ComenzarHilos(this List<Thread> listaHilos)
        {
            if (listaHilos.Count == 0 || listaHilos == null)
                throw new ListaVaciaException();

            foreach (Thread hilo in listaHilos)
            {
                hilo.Start();
            }

            return true;
        }

        public static bool DetenerHilos(this List<Thread> listaHilos)
        {

            foreach (Thread hilo in listaHilos)
            {
                hilo.Abort();
            }

            return true;
        }

        public static void IniciarPedidos(this List<Pedido> listaPedidos)
        {
            if (listaPedidos.Count == 0 || listaPedidos == null)
                throw new ListaVaciaException();

            
            foreach (Pedido pedido in listaPedidos)
            {
                Temporizador.ComenzarTemporizador<Pedido>(pedido);
            }
        }
        public static List<Pedido> GetPedidosByEstado(this List<Pedido> listaPedidos, EEstadoPedido estado)
        {
            List<Pedido> pedidos = new List<Pedido>();
            foreach (Pedido pedido in listaPedidos)
            {
                if (pedido.EstadoPedido == estado)
                    pedidos.Add(pedido);
            }

            return pedidos;
        }
    }
}
