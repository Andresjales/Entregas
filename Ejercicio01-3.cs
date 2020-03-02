using System;

namespace _01_03
{
    class Program
    {
        static void Main()
        {
			//Ingreso de datos
			Console.WriteLine("Ingrese el valor de z: ");
			double z = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de c: ");
			double cGrados = double.Parse(Console.ReadLine());
			//Conversion de angulos a radianes
			double c = cGrados * (Math.PI / 180.0);
			//Calculo de los valores
			double y = z / (Math.Tan(c));
			double t = z / (Math.Sin(c));
			double aGrados = 180 - (cGrados + 90);
			//Imprimir salida
			Console.WriteLine("y: " + y);
			Console.WriteLine("t: " + t);
			Console.WriteLine("a: " + aGrados);
		}
    }
}
