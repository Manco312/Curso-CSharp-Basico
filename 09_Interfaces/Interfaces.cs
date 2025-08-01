using System;

interface IVehiculo
{
    void Conducir();
}

class Auto : IVehiculo
{
    public void Conducir()
    {
        Console.WriteLine("Conduciendo auto...");
    }
}

class Program
{
    static void Main()
    {
        IVehiculo miAuto = new Auto();
        miAuto.Conducir();
    }
}
