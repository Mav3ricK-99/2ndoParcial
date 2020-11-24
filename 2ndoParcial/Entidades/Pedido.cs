using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public enum EEstadoPedido
    {
        EnPreparacion,
        Entregado
    }
    public enum EOpciones
    {
        Hamburguesa = 15,
        HamburguesaTripleChedar = 70,
        GrandBacon = 100,
        GrandDobleMcBacon = 110,
        GrandTripleMcBacon = 120,
        Croccantela = 30,
        DobleMcNífica = 90,
        TripleMcNífica = 115,
        ExtraMcNíficas = 130,
        DobleCuartoDeLibraConQueso = 100,
        BigMac = 50,
        McNuggets = 20,
        Papas = 10,
        McPollo = 45,
        McCafe = 35,
    }
    [Serializable]
    public class Pedido : ITemporizador, IEstado, IDb
    {
        private static int idPedidoClase;
        private int idPedido, tiempoPreparacion;
        private bool isDelivery;
        private DateTime horaPedidoFecha;
        private EOpciones opcionPedido;
        private EEstadoPedido estadoPedido;
        private string infoDelivery = "No Delivery";
        
        public int N_Pedido { get => idPedido; set => idPedido = value; }
        public string NombrePedido { get => FormatNombrePedido(); }
        public EOpciones OpcionPedido { get => opcionPedido; set => opcionPedido = value; }
        public bool EsDelivery { get => isDelivery; set => isDelivery = value; }
        public string InfoDelivery { get => infoDelivery; set => infoDelivery = value; }
        public int TiempoTotal { get => tiempoPreparacion; set => tiempoPreparacion = value; }
        public string HoraPedido { get => horaPedidoFecha.ToString(@"HH\:mm\:ss"); }
        public string TiempoEnMinutos { get => TimeSpan.FromSeconds(tiempoPreparacion).ToString(@"mm\:ss"); }
        public EEstadoPedido EstadoPedido { get => estadoPedido; set => estadoPedido = value; }
        public static int IdPedidoClase { get => idPedidoClase; set => idPedidoClase = value; }
        public DateTime HoraPedidoFecha { get => horaPedidoFecha; set => horaPedidoFecha = value; }

        public Pedido() { 
            this.idPedido = idPedidoClase++;
            this.HoraPedidoFecha = DateTime.Now;
        }

        public Pedido(EOpciones opcion) : this()
        {
            this.opcionPedido = opcion;
            this.tiempoPreparacion = (int)opcion;
            this.estadoPedido = EEstadoPedido.EnPreparacion;
        }

        public Pedido(EOpciones opcion, string infoDelivery) : this(opcion)
        {
            this.isDelivery = true;
            this.infoDelivery = infoDelivery;
        }

        private string FormatNombrePedido()
        {
            string nombrePedido = this.OpcionPedido.ToString();
            string rtrn = string.Empty;
            for (int i = 0; i < nombrePedido.Length; i++)
            {
                if (char.IsUpper(nombrePedido[i]))
                    rtrn = nombrePedido.Insert(i, " ");
            }
            return rtrn;
        }

        public void Object_To_DB(ref SqlCommand command)
        {
            string sql = "INSERT INTO Pedidos(OpcionPedido, IsDelivery, InfoDelivery) values(@OpcionPedido, @IsDelivery, @InfoDelivery)";
            command.CommandText = sql;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@OpcionPedido", this.opcionPedido.ToString());
            command.Parameters.AddWithValue("@IsDelivery", this.isDelivery);
            command.Parameters.AddWithValue("@InfoDelivery", this.infoDelivery);

        }

        public void DB_Select_Query(ref SqlCommand command)
        {
            throw new NotImplementedException();
        }

        public void DB_UpdateObject(ref SqlCommand command)
        {
            throw new NotImplementedException();
        }

        public object DB_GetObjectFromRegistro(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public void DB_Delete_Reg(ref SqlCommand command)
        {
            throw new NotImplementedException();
        }

        public static bool Guardar(Pedido pedido)
        {
            bool rtrn = false;
            Texto archivoTxt = new Texto();

            StringBuilder rutaStr = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
            string nombreArchivo = $"Pedido_Numero_{pedido.idPedido}.txt";
            rutaStr.Append(nombreArchivo);

            if (archivoTxt.Guardar(rutaStr.ToString(), pedido.ToString()))
            {
                rtrn = true;
            }

            return rtrn;
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Pedido Numero N° {this.idPedido}\n");
            strBuilder.Append($"________________________\n");
            strBuilder.Append($"Pedido de {this.opcionPedido.ToString()}\n");
            strBuilder.Append($"Direccion: {this.infoDelivery}\n");

            return strBuilder.ToString();
        }
    }
}
