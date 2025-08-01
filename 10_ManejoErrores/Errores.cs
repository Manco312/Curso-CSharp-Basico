using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int resultado = a / b;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: División por cero.");
        }
        finally
        {
            Console.WriteLine("Bloque finally ejecutado.");
        }
    }
}
