using System;

namespace Ejercicio_3___1
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
                Console.WriteLine("Su tarifa es la A.");
            }
            else if ((2 * smmlv) <= salario && salario < (4 * smmlv) )
            {
                Console.WriteLine("Su tarifa es la B.");
            }
            else
            {
                Console.WriteLine("Su tarifa es la C.");
            }
        }
    }
}
