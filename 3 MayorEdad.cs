using System;

namespace MayorEdad
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Es menor de edad.");
            }
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
