using System;

namespace Ejercicio_3___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());
            int smmlv = 877803;

            if (salario < (2 * smmlv))
            {
                int cm = 3400;
                Console.WriteLine("Su tarifa es la A y el valor de su cuota moderadora es de: " + cm);
            }
            else if ((2 * smmlv) <= salario && salario < (5 * smmlv))
            {
                int cm = 13500;
                Console.WriteLine("Su tarifa es la B y el valor de su cuota moderadora es de: " + cm);
            }
            else
            {
                int cm = 35600;
                Console.WriteLine("Su tarifa es la C y el valor de su cuota moderadora es de: " + cm);
            }
        }
    }
}
