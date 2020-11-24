using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;

namespace ExceptionTest
{
    [TestClass]
    public class ExcepcionesTest
    {
        [TestMethod]
        [ExpectedException(typeof(ListaVaciaException))]
        public void ListaVaciaException()
        {
            List<Pedido> listaPedidos = new List<Pedido>();
            listaPedidos.IniciarPedidos();

        }

        [TestMethod]
        [ExpectedException(typeof(ListaVaciaException))]
        public void LeerPedidosException()
        {
            //System.IO.File.Move(@"C:/", destinationFile);
        }
        

    }
}
