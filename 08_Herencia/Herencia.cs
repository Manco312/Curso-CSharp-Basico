using System;

class Animal
{
    public void HacerSonido()
    {
        Console.WriteLine("Sonido genérico.");
    }
}

class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine("Guau guau!");
    }
}

class Program
{
    static void Main()
    {
        Perro perro = new Perro();
        perro.HacerSonido();
        perro.Ladrar();
    }
}
