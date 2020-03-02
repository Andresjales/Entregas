using System;

namespace Ejercicio_2___1
{
    class Program
    {
        static void Main()
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());
            //cambio de grados a radianes
            double b = bGrados * (Math.PI / 180);
            //Calculo de valores
            double a = Math.Atan(y / z);
            double ab = (a + b);
            double xy = Math.Tan(ab) * z;
            double x = xy - y;
            //Salida de datos
            Console.WriteLine("x: " + x);
        }
    }
}
