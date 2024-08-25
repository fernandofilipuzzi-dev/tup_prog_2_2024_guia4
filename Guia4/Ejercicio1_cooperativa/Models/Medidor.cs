
namespace Ejercicio1.Models
{
    class Medidor
    {
        public double LecturaAnterior { get; private set; }
        public double LecturaActual { get; private set; }

        public Medidor()
        {
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
    }
}
