using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace LocalForms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Negocio.NombreNegocio = "Comidas Rapidas";
            Negocio.IniciarNegocio();
            //Negocio.AgregarPedido(new Pedido(EOpciones.GrandBacon));
            //Negocio.GuardarPedidos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
