using System;

class Persona
{
    public string Nombre;
    public int Edad;

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
    }
}

class Program
{
    static void Main()
    {
        Persona persona = new Persona();
        persona.Nombre = "Laura";
        persona.Edad = 30;
        persona.Saludar();
    }
}
