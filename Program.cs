using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo para almacenar los 10 números
        int[] numeros = new int[10];

        // Leer los 10 números desde la consola
        Console.WriteLine("Ingrese 10 números:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Ordenar el arreglo
        Array.Sort(numeros);

        // Mostrar los números ordenados
        Console.WriteLine("\nNúmeros ordenados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

