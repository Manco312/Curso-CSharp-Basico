using System;

class Program
{
    static void Main()
    {
        int numero = 20;

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }

        switch (numero)
        {
            case 10:
                Console.WriteLine("Es diez.");
                break;
            case 20:
                Console.WriteLine("Es veinte.");
                break;
            default:
                Console.WriteLine("Otro número.");
                break;
        }
    }
}
