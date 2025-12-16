using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en °C: ");
        int t = int.Parse(Console.ReadLine());

        if (t < 0)
            Console.WriteLine("Hace mucho frío");
        else if (t <= 20)
            Console.WriteLine("Clima fresco");
        else if (t <= 30)
            Console.WriteLine("Clima agradable");
        else
            Console.WriteLine("Hace mucho calor");
    }
}
