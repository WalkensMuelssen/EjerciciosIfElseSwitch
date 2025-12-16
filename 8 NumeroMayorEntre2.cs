using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
            Console.WriteLine("El mayor es: " + a);
        else if (b > a)
            Console.WriteLine("El mayor es: " + b);
        else
            Console.WriteLine("Ambos números son iguales");
    }
}
