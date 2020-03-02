using System;

namespace _02_02
{
    class Program
    {
        static void Main()
        {
			//Ingreso de datos
			Console.WriteLine("Ingrese el valor de t: ");
			double t = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de a: ");
			double aGrados = double.Parse(Console.ReadLine());
			//Conversion de angulos a radianes
			double a = aGrados * (Math.PI / 180.0);
			//Calculo de los valores
			double z = (Math.Cos(a)) * t;
			double y = (Math.Sin(a)) * t;
			double cGrados = 180 - (aGrados + 90);
			//Imprimir salida
			Console.WriteLine("z: " + z);
			Console.WriteLine("y: " + y);
			Console.WriteLine("c: " + cGrados);
		}
    }
}
