using System;

namespace NúmeroPositivoNegativoCero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (num < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

    }
}


   