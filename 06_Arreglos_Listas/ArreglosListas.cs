using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3 };
        foreach (int n in numeros)
            Console.WriteLine($"Array: {n}");

        List<string> nombres = new List<string> { "Ana", "Luis", "Carlos" };
        nombres.Add("María");
        foreach (string nombre in nombres)
            Console.WriteLine($"Lista: {nombre}");
    }
}
