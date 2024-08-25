using System;

namespace Ejercicio1.Models
{
using System.Collections;

    class Cliente : IComparable
    {
        #region relativo al servicio
        public int NroServicio { get; private set; }
        private ArrayList consumos = new ArrayList();
        public int CantidadConsumos { get { return consumos.Count; } }

        /*al año son seies periodos, más uno para luego mostrar el mismo periodo del año anterior*/
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
        public Medidor Medidor { get; set; }
        #endregion fin servicio

        #region relativo cliente
        public string Nombre { get; private set; }
        public int DNI { get; private set; }
        public string Direccion { get; private set; }
        #endregion

        public Cliente(int NroServicio,
                            int dni, string nombre,
                            string direccion, Medidor medidor)
        {
            this.NroServicio = NroServicio;
            this.Nombre = nombre;
            this.DNI = dni;
            this.Direccion = direccion;

            this.Medidor = medidor;
        }

        public void RegistrarConsumo(double medicion)
        {
            PeriodoActual++;
            //Medidor.LecturaActual = medicion;//gracias al mecanismo readonly!
            Medidor.Medicion(medicion);
            consumos.Add(Medidor.ConsumoActual());            
        }

        public int CompareTo(object obj)
        {
            int result = 1;
            if (obj != null && obj is Cliente)
            {
                Cliente obj1 = (Cliente)obj;
                result = this.NroServicio.CompareTo(obj1.NroServicio);
            }
            return result;
        }

        public override string ToString()
        {
            return Nombre + "(" + DNI + ")";
        }

        //métodos relativos al servicio

        public double LeerConsumo(int pos)
        {
            return (double)consumos[pos];
        }
    }
}
