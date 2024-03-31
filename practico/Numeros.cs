
using System;
namespace practico
{

  public class Numero
   {
        public void ejercicio1()
        {
            Console.WriteLine("ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int mayorDigito = 0;
            while (numero >0)
            {
               int digito =numero % 10;
               if (digito > mayorDigito)
               {
                    mayorDigito = digito;
               } 
               numero /= 10;
            } 
             Console.WriteLine($"El mayor digito del numero: {mayorDigito}");   
        }

        public void ejercicio2()
        {
            Console.WriteLine("ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            while (numero >0)
            {
                int digito = numero % 10;
                if (digito % 2 == 0)
                {
                    suma += digito;
                }
                numero /= 10;
            }
            Console.WriteLine(suma);
            Console.WriteLine($"La suma de los digitos pares del numero ingresado es: {suma} ");
        }

        public void ejercicio3()
        {
            Console.WriteLine("ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El numero con el mayor digito al final es: " + ejercicio3_rec(numero));
           
        }

        public static int ejercicio3_rec(int numero)
        {
            int mayorDigito = 0;
            int tempNumero = numero;
            int longitud = numero.ToString().Length;

            //encontrar el mayor digito
            while (tempNumero > 0)
            {
                int digito = tempNumero % 10;
                if (digito > mayorDigito)
                {
                    mayorDigito = digito;
                }
                tempNumero /= 10;
            }
            //reorganizar el numero
            int nuevoNumero = 0; 
            int potencia = 1;
            for (int i = 0; i < longitud; i++)
            {
                int digito = numero % 10;
                numero /= 10;
                if (digito != mayorDigito)
                {
                    nuevoNumero += digito * potencia;
                    potencia *= 10;
                }
               
            }
            nuevoNumero += mayorDigito * potencia; //agregar el mayor digito al final
            return nuevoNumero;
        }

         public void ejercicio4()
        {
            Console.WriteLine("ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los digitos de {0} estan ordenados {1}", numero, ejercicio4_rec(numero));
        }
        static bool ejercicio4_rec(int numero)
        {
            string numeroString = numero.ToString();
            for (int i = 0; i < numeroString.Length - 1; i++)
            {
                if (numeroString[i] > numeroString[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

         public void ejercicio5()
        {
            Console.WriteLine("ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La cantidad de digitos impares antes del primer numero par en {0}: {1}",numero, ejercicio5_rec(numero));
        }
        static int ejercicio5_rec(int numero)
        {
            string numeroString = numero.ToString();
            int cantidadImpares = 0;
            bool encontradoPar = false;

            foreach (char digitoChar in numeroString)
            {
                int digito = int.Parse(digitoChar.ToString());

                if (!encontradoPar)
                {
                    if (digito % 2 !=0)
                    {
                        cantidadImpares++;
                    }
                    else
                    {
                        encontradoPar = true;
                    }
                }         
            } 
            return cantidadImpares;           
        }

   }   
}