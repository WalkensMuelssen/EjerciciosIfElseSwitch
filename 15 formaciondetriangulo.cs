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

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Sí forma un triángulo");
        else
            Console.WriteLine("No forma un triángulo");
    }
}
