using System;

class Program
{
    static void Main()
    {
        Saludar("Ana");
        int suma = Sumar(5, 7);
        Console.WriteLine($"La suma es: {suma}");
    }

    static void Saludar(string nombre)
    {
        Console.WriteLine($"Hola, {nombre}!");
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }
}
