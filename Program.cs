using System;

class Program
{
    static void Main()
    {
       
        int[] numeros = new int[10];

     
        Console.WriteLine("Ingrese 10 números:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numeros);

       
        Console.WriteLine("\nNúmeros ordenados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

