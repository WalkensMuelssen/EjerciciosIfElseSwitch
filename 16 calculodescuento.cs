using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());
        double descuento = 0;

        if (precio >= 50 && precio <= 100)
            descuento = precio * 0.05;
        else if (precio > 100)
            descuento = precio * 0.10;

        Console.WriteLine("Total a pagar: " + (precio - descuento));
    }
}
