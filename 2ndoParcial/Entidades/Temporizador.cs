using System.Collections.Generic;
using System.Threading;

namespace Entidades
{
    static class Temporizador
    {
        private static List<Thread> listaTemporizadores;

        static Temporizador()
        {
            listaTemporizadores = new List<Thread>();
        }
        public static void ComenzarTemporizador<T>(T objeto) where T : ITemporizador, IEstado
        {
            Thread tempo = new Thread(() => Temporizar(objeto));
            listaTemporizadores.Add(tempo);
            tempo.Start();
        }

        private static void Temporizar<T>(T objeto) where T : ITemporizador, IEstado
        {
            while (objeto.TiempoTotal != 0) {
                objeto.TiempoTotal -= 1;
                Thread.Sleep(1000);
            }
            if (objeto.TiempoTotal == 0)
                objeto.EstadoPedido = EEstadoPedido.Entregado;
        }
        public static void DetenerTemporizadores()
        {
            listaTemporizadores.DetenerHilos();
        }
    }
}
