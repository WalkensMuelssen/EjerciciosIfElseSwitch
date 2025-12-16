using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad > 60)
            Console.WriteLine("Aplica para el descuento del 50%");
        else
            Console.WriteLine("No aplica para el descuento");
    }
}
