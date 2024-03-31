using System;
namespace Practico
{
public class Vectores
{
   
    public void Ejercicio1()
    {
        Console.WriteLine("Ingrese una lista de números separados por comas:");
        string[] numerosStr = Console.ReadLine().Split(',');
        int[] numeros = new int[numerosStr.Length];
        for (int i = 0; i < numerosStr.Length; i++)
        {
            numeros[i] = int.Parse(numerosStr[i]);
        }

        int cantidadPares = ContarPares(numeros);
        Console.WriteLine("La cantidad de números pares en la lista es: " + cantidadPares);
    }

    public int ContarPares(int[] numeros)
    {
        int count = 0;
        foreach (var num in numeros)
        {
            if (EsPar(num))
            {
                count++;
            }
        }
        return count;
    }

    public bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }

    public void Ejercicio2()
    {
        Console.WriteLine("Ingrese una lista de números separados por comas para ordenar:");
        string[] numerosStr = Console.ReadLine().Split(',');
        int[] numeros = new int[numerosStr.Length];
        for (int i = 0; i < numerosStr.Length; i++)
        {
            numeros[i] = int.Parse(numerosStr[i]);
        }

        Console.WriteLine("Lista antes de ordenar:");
        ImprimirArray(numeros);

        MergeSort(numeros);

        Console.WriteLine("Lista después de ordenar:");
        ImprimirArray(numeros);
    }

    public void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int medio = arr.Length / 2;
        int[] izquierda = new int[medio];
        int[] derecha = new int[arr.Length - medio];

        Array.Copy(arr, 0, izquierda, 0, medio);
        Array.Copy(arr, medio, derecha, 0, arr.Length - medio);

        MergeSort(izquierda);
        MergeSort(derecha);

        Merge(arr, izquierda, derecha);
    }

    public void Merge(int[] arr, int[] izquierda, int[] derecha)
    {
        int i = 0, j = 0, k = 0;

        while (i < izquierda.Length && j < derecha.Length)
        {
            if (izquierda[i] <= derecha[j])
            {
                arr[k] = izquierda[i];
                i++;
            }
            else
            {
                arr[k] = derecha[j];
                j++;
            }
            k++;
        }

        while (i < izquierda.Length)
        {
            arr[k] = izquierda[i];
            i++;
            k++;
        }

        while (j < derecha.Length)
        {
            arr[k] = derecha[j];
            j++;
            k++;
        }
    }

    public void ImprimirArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

     public void Ejercicio3()
    {
        Console.WriteLine("Ingrese una lista de números separados por comas para ordenar:");
        string[] numerosStr = Console.ReadLine().Split(',');
        int[] numeros = new int[numerosStr.Length];
        for (int i = 0; i < numerosStr.Length; i++)
        {
            numeros[i] = int.Parse(numerosStr[i]);
        }

        Console.WriteLine("Lista antes de ordenar:");
        ImprimirArray(numeros);

        InsertionSort(numeros);

        Console.WriteLine("Lista después de ordenar:");
        ImprimirArray(numeros);
    }

    public void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

     public void Ejercicio4()
    {
        Console.WriteLine("Ingrese una lista de números separados por comas:");
        string[] numerosStr = Console.ReadLine().Split(',');
        int[] numeros = new int[numerosStr.Length];
        for (int i = 0; i < numerosStr.Length; i++)
        {
            numeros[i] = int.Parse(numerosStr[i]);
        }

        Console.WriteLine("Ingrese el número que desea eliminar:");
        int datoEliminar = int.Parse(Console.ReadLine());

        EliminarNumero(ref numeros, datoEliminar);

        Console.WriteLine("Lista después de eliminar el número " + datoEliminar + ":");
        ImprimirArray(numeros);
    }

    public void EliminarNumero(ref int[] arr, int numero)
    {
        int index;
        while ((index = Array.IndexOf(arr, numero)) != -1)
        {
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        if (index == -1)
        {
            Console.WriteLine("El número " + numero + " no está presente en la lista.");
        }
    }

      public void Ejercicio5()
    {
        Console.WriteLine("Ingrese una lista de números separados por comas:");
        string[] numerosStr = Console.ReadLine().Split(',');
        int[] numeros = new int[numerosStr.Length];
        for (int i = 0; i < numerosStr.Length; i++)
        {
            numeros[i] = int.Parse(numerosStr[i]);
        }

        Console.WriteLine("Ingrese el índice 'a' para la inversión:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el índice 'b' para la inversión:");
        int b = int.Parse(Console.ReadLine());

        InvertirParte(ref numeros, a, b);

        Console.WriteLine("Lista después de invertir entre los índices " + a + " y " + b + ":");
        ImprimirArray(numeros);
    }

    public void InvertirParte(ref int[] arr, int a, int b)
    {
        if (a < 0 || b >= arr.Length || a >= b)
        {
            Console.WriteLine("Índices inválidos.");
            return;
        }

        while (a < b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
            a++;
            b--;
        }
    }

}
}
