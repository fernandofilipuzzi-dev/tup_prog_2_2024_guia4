using System;

namespace Ejercicio1.Models
{
using System.Collections;

    class Cliente : IComparable
    {
        public Medidor Medidor { get; private set; }
        
        public string Nombre { get; private set; }
        public int DNI { get; private set; }
        public string Direccion { get; private set; }
     
        public Cliente(int dni, string nombre, string direccion, Medidor medidor)
        {
            this.Nombre = nombre;
            this.DNI = dni;
            this.Direccion = direccion;

            this.Medidor = medidor;
        }

        public int CompareTo(object obj)
        {
            int result = 1;
            Cliente c=obj as Cliente;
            if (c != null)
            {
                result = this.Medidor.NumeroServicio.CompareTo(c.Medidor.NumeroServicio);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Nombre}  ( {DNI} )";
        }

    }
}
