
using System.Collections;

namespace Ejercicio1.Models
{
    class Medidor
    {
        public int NumeroServicio { get; private set; }
        public double LecturaAnterior { get; private set; }
        public double LecturaActual { get; private set; }

        private ArrayList consumos = new ArrayList();
        public int CantidadConsumos { get { return consumos.Count; } }

        private int periodoActual;
        public int PeriodoActual
        {
            get { return periodoActual; }
            private set
            {
                if (CantidadConsumos == 8)//hay varias formas de implementar esto
                    consumos.RemoveAt(0);
                periodoActual = value % 6;
            }

        }

        public Medidor(int numeroServicio)
        {
            this.NumeroServicio = numeroServicio;
        }
               
        public double ConsumoActual()
        {
            return LecturaActual - LecturaAnterior;
        }
             
        public void Medicion(double lectura)
        {
            LecturaAnterior = LecturaActual;
            LecturaActual = lectura;
        }

        public void RegistrarConsumo(double medicion)
        {
            PeriodoActual++;
            LecturaActual = medicion;
            consumos.Add(ConsumoActual());
        }

        public double LeerConsumo(int pos)
        {
            return (double)consumos[pos];
        }
    }
}
