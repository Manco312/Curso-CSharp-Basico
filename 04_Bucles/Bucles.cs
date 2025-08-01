using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
            Console.WriteLine($"For: {i}");

        int j = 0;
        while (j < 3)
        {
            Console.WriteLine($"While: {j}");
            j++;
        }

        List<string> frutas = new List<string> { "Manzana", "Banana", "Cereza" };
        foreach (var fruta in frutas)
            Console.WriteLine($"Foreach: {fruta}");
    }
}
