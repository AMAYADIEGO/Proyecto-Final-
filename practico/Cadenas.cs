using System;
namespace practico
{

     public class Cadenas
     {
          public void ejercicio1()
          {
          int Cantpal = 0, c = 1;
          Console.WriteLine("1.Contador de palabras");
          Console.WriteLine("Ingresar palabras: ");
          string s = Console.ReadLine();
          while(Cantpal < s.Length)
          {
               if (s[Cantpal] == ' ')
               {
                    c = c + 1;
               }
               Cantpal = Cantpal + c;
          }
          Console.WriteLine($"Hay  {c} palabras");
          Console.WriteLine();
          }
          public void ejercicio2()
          {
               Console.WriteLine("2.Elimina solo las vocales ");
               Console.WriteLine("Ingresar palabras: ");
               string input = Console.ReadLine();

               string result = EliminarVocales(input);

               Console.WriteLine("Elimino las vocales:");
               Console.WriteLine(result);
               Console.WriteLine();
               static string EliminarVocales(string cadena)
               {
                    string vowels = "aeiouAEIOU";
                    string result = "";

                    foreach (char c in cadena)
                    {
                         if (!vowels.Contains(c))
                         {
                              result += c;
                         }
                    }

                    return result;
               }
               

          }
          
          public void ejercicio3()
          {
               Console.WriteLine("3.devolver la palabra mas larga");
               Console.WriteLine("Ingrese palabras");
               string CadenaMasLarga = Console.ReadLine();
               string[] Palabras = CadenaMasLarga.Split();

               string PalabraLarga = "";
               foreach (string Palabra1 in Palabras)
               {
                    if (Palabra1.Length>PalabraLarga.Length)
                    PalabraLarga = Palabra1;
               }
               Console.WriteLine($"La palabra mas larga es:");
               Console.WriteLine(PalabraLarga);
               Console.WriteLine();
          }
          public void ejercicio4()
          {
               Console.WriteLine("4.Elimina la primera letra de cada palabra");
               Console.WriteLine("Ingresa palabra:");
               string input = Console.ReadLine();
               string resultado = EliminarPrimeraLetra(input);
               Console.WriteLine("Eliminado: ");
               Console.WriteLine(resultado);
               Console.WriteLine();
               static string EliminarPrimeraLetra(string input)
               {
                    string[] palabras = input.Split(' ');
                    for (int i = 0; i < palabras.Length; i++)
                    {
                         if (palabras[i].Length > 1)
                         {
                              palabras[i] = palabras[i].Substring(1);
                         }
                         else
                         {
                              palabras[i] = ""; // Si la palabra tiene solo una letra, se elimina completamente
                         }
                    }
                    return string.Join(" ", palabras);
               }

          }
          public void ejercicio5()
          {
               Console.WriteLine("5.Invertir palabras");
               Console.WriteLine("Ingrese palabras");
               string s =Console.ReadLine();
               int InvertiPal = s.Length - 1;
               string aux = "";
               while(InvertiPal >= 0 )
               {
                    aux = aux + s[InvertiPal];
                    InvertiPal = InvertiPal - 1;
               }
               Console.WriteLine("Invertido: "+aux);
               Console.WriteLine();

          }

     }

}