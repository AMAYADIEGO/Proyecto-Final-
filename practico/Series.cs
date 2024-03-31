using System;


namespace practico
{
    public class Series
    {
        public void ejercicio1()
        {
            Console.WriteLine("Ingrese el valor de n para el ejercicio 1:");
            int n = Convert.ToInt32(Console.ReadLine());
            int resultado = CalcularFibonacci(n);
            Console.WriteLine($"El {n}-ésimo término de la serie de Fibonacci es: {resultado}");
        }

        public void ejercicio2()
        {
            Console.WriteLine("Ingrese el valor de n para el ejercicio 2:");
            int n = Convert.ToInt32(Console.ReadLine());
            int resultado = CalcularSerie1(n);
            Console.WriteLine($"El {n}-ésimo término de la serie 1 es: {resultado}");
        }

        public void ejercicio3()
        {
            Console.WriteLine("Ingrese el valor de n para el ejercicio 3:");
            int n = Convert.ToInt32(Console.ReadLine());
            int resultado = CalcularSumaSerie(n);
            Console.WriteLine($"La suma de los primeros {n} términos de la serie es: {resultado}");
        }

        public void ejercicio4()
        {
            Console.WriteLine("Ingrese el valor de n para el ejercicio 4:");
            int n = Convert.ToInt32(Console.ReadLine());
            int resultado = CalcularSerie2(n);
            Console.WriteLine($"El {n}-ésimo término de la serie 2 es: {resultado}");
        }

        public void ejercicio5()
        {
            Console.WriteLine("Ingrese el valor de n para el ejercicio 5:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> serie = GenerarSerie(n);
            int sumaPares = SumarNumerosPares(serie);
            Console.WriteLine($"La suma de los números pares de la serie es: {sumaPares}");
        }

        public List<int> GenerarSerie(int n)
        {
            List<int> serie = new List<int>();
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                serie.Add(num);
                if (i == 4)
                {
                    num *= 2;
                }
                else if (i == 5)
                {
                    num += 2;
                }
                else if (i == 6)
                {
                    num += 1;
                }
                else if (i == 7)
                {
                    num *= 2;
                }
                else if (i == 8)
                {
                    num += 2;
                }
                else if (i % 4 == 0)
                {
                    num += 1;
                }
                else if (i % 2 == 0)
                {
                    num *= 2;
                }
                else
                {
                    num += 1;
                }
            }
            return serie;
        }

        public int SumarNumerosPares(List<int> serie)
        {
            int suma = 0;
            foreach (int num in serie)
            {
                if (num % 2 == 0)
                {
                    suma += num;
                }
            }
            return suma;
        }

        public int CalcularFibonacci(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("El valor de n debe ser mayor que cero.");
            }

            if (n == 1 || n == 2)
            {
                return n - 1; // Los primeros dos términos de Fibonacci son 0 y 1
            }

            int a = 0;
            int b = 1;
            int result = 0;

            for (int i = 2; i < n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }

        public int CalcularSerie1(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int valor = 1;
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    valor *= 2;
                }
                else
                {
                    valor += 1;
                }
            }

            return valor;
        }

        public int CalcularSumaSerie(int n)
        {
            // La serie es una progresión aritmética donde d = 2
            // La suma de los primeros n términos es n * (primer término + último término) / 2
            return n * (0 + 2 * (n - 1)) / 2;
        }

        public int CalcularSerie2(int n)
        {
            // Generar la serie según la lógica requerida
            int num = 1;
            for (int i = 1; i < n; i++)
            {
                num = num * 2 + 1;
            }
            return num;
        }
    }
}
