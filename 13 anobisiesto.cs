using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un año: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            Console.WriteLine("Año bisiesto");
        else
            Console.WriteLine("No es bisiesto");
    }
}
