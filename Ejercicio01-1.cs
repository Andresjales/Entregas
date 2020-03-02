using System;

namespace _02_01
{
    class Program
    {
        static void Main()
        {
			//Ingreso de datos
			Console.WriteLine("Ingrese el valor de y: ");
			double y = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de z: ");
			double z = double.Parse(Console.ReadLine());
			//Calculo de los valores
			double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
			double aGrados = (Math.Asin(y / t)) * (180 / Math.PI);
			double cGrados = (Math.Asin(z / t)) * (180 / Math.PI);
			//Imprimir salida
			Console.WriteLine("t: " + t);
			Console.WriteLine("a: " + aGrados);
			Console.WriteLine("c: " + cGrados);
		}
    }
}
