using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;
using System.IO;

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
        [ExpectedException(typeof(LeerPedidosException))]
        public void LeerPedidosException()
        {
            System.IO.File.Move("C:\\Users\\feder\\source\\repos\\2ndoParcial\\2ndoParcial\\LocalForms\\bin\\Debug\\Pedidos.xml", "C:\\Users\\feder\\source\\repos\\2ndoParcial\\2ndoParcial\\LocalForms\\bin\\Pedidos.xml");
            Negocio.LeerPedidos();
            System.IO.File.Move("C:\\Users\\feder\\source\\repos\\2ndoParcial\\2ndoParcial\\LocalForms\\bin\\Pedidos.xml", "C:\\Users\\feder\\source\\repos\\2ndoParcial\\2ndoParcial\\LocalForms\\bin\\Debug\\Pedidos.xml");

        }


    }
}
