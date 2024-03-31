using System;


namespace practico
{
    public class Matrices
    {
            public void ejercicio1()
            {
                Console.WriteLine("Ingrese el número de filas:");
                int filas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el número de columnas:");
                int columnas = Convert.ToInt32(Console.ReadLine());

              
                int[,] matriz = new int[filas, columnas];

                int numero = 1;

                for (int f = filas - 1; f >= 0; f--)
                {
                    for (int c = f; c >= 0; c--)
                    {
                        matriz[f, c] = numero++;
                    }
                }

                Console.WriteLine("Matriz resultante:");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        public void ejercicio2()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());


            int[,] matriz = new int[filas, columnas];

            int numero = 1;

            for (int c = 0; c < columnas; c++)
            {
                for (int f = c; f < filas; f++)
                {
                    matriz[f, c] = numero++;
                }
            }

            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ejercicio3()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());


            int[,] matriz = new int[filas, columnas];

            int valor = 1;

            for (int c = 0; c < columnas; c++)
            {
                bool derecha = c % 2 == 0;
                if (derecha)
                {
                    for (int f = 0; f < filas; f++)
                    {
                        matriz[f, c] = valor++;
                    }
                }
                else
                {
                    for (int f = filas - 1; f >= 0; f--)
                    {
                        matriz[f, c] = valor++;
                    }
                }
            }

            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ejercicio4()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());


            int[,] cuadradoMagico = new int[filas, filas];
            int num = 1;
            int i = 0;
            int j = filas / 2;

            while (num <= filas * filas)
            {
                cuadradoMagico[i, j] = num;

                num++;
                int nuevoI = (i - 1 + filas) % filas;
                int nuevoJ = (j + 1) % filas;

                if (cuadradoMagico[nuevoI, nuevoJ] != 0)
                {
                    i = (i + 1) % filas;
                }
                else
                {
                    i = nuevoI;
                    j = nuevoJ;
                }
            }

            Console.WriteLine("Cuadrado Mágico:");
            for (int row = 0; row < filas; row++)
            {
                for (int col = 0; col < filas; col++)
                {
                    Console.Write(cuadradoMagico[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ejercicio5()
        {
            Console.WriteLine("Ingrese el número de filas:");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = Convert.ToInt32(Console.ReadLine());


            int[,] matriz = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = Math.Min(filas - f, columnas - c);
                }
            }

            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        










        public void ImprimirMatriz<T>(T[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
