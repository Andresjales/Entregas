using System;

namespace Ejercicio_2___4
{
    class Program
    {
        static void Main()
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese t: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c: ");
            double cGrados = double.Parse(Console.ReadLine());
            //Conversion de grados a radianes
            double c = cGrados * (Math.PI / 180);
            //Calculo de valores
            double y = Math.Cos(c) * t;
            double aGrados = 180 - (cGrados + 90);
            double a = aGrados * (Math.PI / 180);
            double z = Math.Cos(a) * t;
            double ab = Math.Acos(z / w);
            double xy = Math.Sin(ab) * w;
            double x = xy - y;
            //Salida de datos
            Console.WriteLine("x: " + x);
        }
    }
}
