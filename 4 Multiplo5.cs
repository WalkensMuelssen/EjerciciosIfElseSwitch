using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 5 == 0)
            Console.WriteLine("El número es múltiplo de 5");
        else
            Console.WriteLine("El número NO es múltiplo de 5");
    }
}
