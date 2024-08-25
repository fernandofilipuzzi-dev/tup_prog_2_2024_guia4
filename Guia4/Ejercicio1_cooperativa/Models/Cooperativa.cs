
using System.Collections;

namespace Ejercicio1.Models
{
    class Cooperativa
    {
      public string Nombre{get; private set;}
      public ArrayList clientes =new ArrayList();

      public Cooperativa(string nombre)
      {
          Nombre = nombre;
      }
        
      public Cliente AgregarCliente(int servicio, int dni, string nombre, 
                      string direccion, Medidor medidor)
      {
          Cliente nuevo = new Cliente(servicio, dni, nombre, direccion, medidor);
          clientes.Add( nuevo) ;
          return nuevo;
      }

      public Cliente BuscarCliente(int nroServicio)
      {
          Cliente buscado = null;

          clientes.Sort();
          //algoritmo de busqueda binaria
          int n = clientes.Count-1;
          int clave = nroServicio;

          int inf = 0, sup = n, centro, pos = -1;
          while (inf <= sup && pos < 0)
          {
              centro =(inf+sup)/2;

              if (((Cliente)clientes[centro]).NroServicio == clave)
              {
                  pos = centro;
              }
              else
              {
                  if (clave > ((Cliente)clientes[centro]).NroServicio)
                  {
                      inf = centro + 1;
                  }
                  else
                  {
                      sup = centro - 1;
                  }
              }
              if (pos > -1)
                  buscado = (Cliente)clientes[pos];             
          }
          return buscado;
      }
    }
}
