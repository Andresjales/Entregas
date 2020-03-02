using System;

namespace Ejercicio_2___3
{
    class Program
    {
        static void Main()
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese d: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese x: ");
            double x = double.Parse(Console.ReadLine());
            //Conversion de grados a radianes
            double d = dGrados * (Math.PI / 180);
            //Calculo de valores
            double xy = Math.Cos(d) * w;
            double y = xy - x;
            //Salida de datos
            Console.WriteLine("y: " + y);
        }
    }
}
