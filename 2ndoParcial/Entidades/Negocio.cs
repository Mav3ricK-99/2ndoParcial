using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Archivos;
using Excepciones;

namespace Entidades
{
    public static class Negocio
    {
        private static string nombreNegocio;
        private static List<Pedido> listaPedidos;
        public static string NombreNegocio { get => nombreNegocio; set => nombreNegocio = value; }
        public static List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

        static Negocio()
        {
            nombreNegocio = "NombreNegocio";
            listaPedidos = new List<Pedido>();
        }
        public static void AgregarPedido(Pedido pedido)
        {
            try
            {
                if (pedido.EsDelivery)
                    Pedido.Guardar(pedido);

                Negocio.listaPedidos.Add(pedido);
                Temporizador.ComenzarTemporizador<Pedido>(pedido);
                DB.Insert<Pedido>(pedido);
            }catch(Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        public static void DetenerPedidos()
        {
            Temporizador.DetenerTemporizadores();
        }
        public static void IniciarNegocio()
        {
            try
            {
                Negocio.LeerPedidos();
            }
            catch (LeerPedidosException e)
            {
                throw new LeerPedidosException(e.Message, e.InnerException);
            }
            catch (ListaVaciaException e)
            {
                throw new LeerPedidosException(e.Message, e.InnerException);
            }
        }

        public static bool GuardarPedidos()
        {
            bool rtrn = true;
            Xml<Pedido> archivoXml = new Xml<Pedido>();

            StringBuilder rutaStr = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
            string nombreArchivo = "Pedidos.xml";
            rutaStr.Append(nombreArchivo);

            if (!archivoXml.Guardar(rutaStr.ToString(), Negocio.ListaPedidos))
            {
                rtrn = false;
            }
            return rtrn;
        }
        public static void LeerPedidos()
        {
            List<Pedido> listaPedidos;
            Xml<Pedido> archivoXml = new Xml<Pedido>();

            try
            {
                StringBuilder rutaStr = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
                string nombreArchivo = "Pedidos.xml";
                rutaStr.Append(nombreArchivo);
                archivoXml.Leer(rutaStr.ToString(), out listaPedidos);
                Negocio.ListaPedidos = listaPedidos;
                Negocio.ListaPedidos.IniciarPedidos();
            }
            catch (ListaVaciaException iniciarPedidosException)
            {
                throw new LeerPedidosException(iniciarPedidosException.Message, iniciarPedidosException.InnerException);
            }
            catch (Exception e)
            {
                throw new LeerPedidosException(e.Message, e.InnerException);
            }

        }
    }
}
