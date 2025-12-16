using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer lado: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo lado: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer lado: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Triángulo equilátero");
        else if (a == b || a == c || b == c)
            Console.WriteLine("Triángulo isósceles");
        else
            Console.WriteLine("Triángulo escaleno");
    }
}
