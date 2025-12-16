using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su salario mensual: ");
        double salario = double.Parse(Console.ReadLine());
        double impuesto;

        if (salario < 10000)
            impuesto = 0;
        else if (salario <= 30000)
            impuesto = salario * 0.10;
        else
            impuesto = salario * 0.20;

        Console.WriteLine("Impuesto aplicado: " + impuesto);
    }
}
