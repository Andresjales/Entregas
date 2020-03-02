using System;

namespace Ejercicio_2___2
{
    class Program
    {
        static void Main()
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese d: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());
            //Calculo de valores
            double eGrados = 180 - (dGrados + bGrados);
            double cGrados = 180 - eGrados;
            double c = cGrados * (Math.PI / 180);
            double z = Math.Tan(c) * y;
            //Salida de datos
            Console.WriteLine("z: " + z);
        }
    }
}
