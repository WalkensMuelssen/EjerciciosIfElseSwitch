using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer número: ");
        int c = int.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
            Console.WriteLine("Hay ceros");
        else if (a > 0 && b > 0 && c > 0)
            Console.WriteLine("Todos positivos");
        else if (a < 0 && b < 0 && c < 0)
            Console.WriteLine("Todos negativos");
        else
            Console.WriteLine("Mixtos");
    }
}
