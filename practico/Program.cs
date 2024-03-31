using System.Numerics;
using Practico;

namespace practico
{
    public class Practico
    {
      public static void Main(string[] args)
      {
          Numero numero = new Numero();
          numero.ejercicio1();
          numero.ejercicio2();
          numero.ejercicio3();
          numero.ejercicio4();
          numero.ejercicio5();

          Series series = new Series();
          series.ejercicio1();
          series.ejercicio2();
          series.ejercicio3();
          series.ejercicio4();
          series.ejercicio5();

          Vectores vectores = new Vectores();
          vectores.Ejercicio1();
          vectores.Ejercicio2();
          vectores.Ejercicio3();
          vectores.Ejercicio4();
          vectores.Ejercicio5();

          Matrices matrices = new Matrices();
          matrices.ejercicio1();
          matrices.ejercicio2();
          matrices.ejercicio3();
          matrices.ejercicio4();
          matrices.ejercicio5();
      }
        
    }
}
