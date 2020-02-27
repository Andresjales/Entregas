using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] CoordsX = { 0, 2, 3, 7 };
            double[] CoordsY = { 0, 1, 5, 6 };

            double m = CoordsY[1] - CoordsY[0] / CoordsX[1] - CoordsX[0];

            if (CoordsY[2] == m * CoordsX[2] && CoordsY[3] == m * CoordsX[3])
            {
                Console.WriteLine("Pasan por la misma linea recta.");
            }
            else
            {
                Console.WriteLine("No pasan por la misma linea recta.");
            }   

            double max = 0;

            double a = Math.Sqrt(Math.Pow(CoordsX[1] - CoordsX[0], 2) + Math.Pow(CoordsY[1] - CoordsY[0], 2));

            if (a > max)
            {
                max = a;
            }

            double b = Math.Sqrt(Math.Pow(CoordsX[2] - CoordsX[0], 2) + Math.Pow(CoordsY[2] - CoordsY[0], 2));

            if (b > max)
            {
                max = b;
            }

            double c = Math.Sqrt(Math.Pow(CoordsX[3] - CoordsX[0], 2) + Math.Pow(CoordsY[3] - CoordsY[0], 2));

            if (c > max)
            {
                max = c;
            }

            double d = Math.Sqrt(Math.Pow(CoordsX[2] - CoordsX[1], 2) + Math.Pow(CoordsY[2] - CoordsY[1], 2));

            if (d > max)
            {
                max = d;
            }

            double e = Math.Sqrt(Math.Pow(CoordsX[3] - CoordsX[1], 2) + Math.Pow(CoordsY[3] - CoordsY[1], 2));

            if (e > max)
            {
                max = e;
            }

            double f = Math.Sqrt(Math.Pow(CoordsX[3] - CoordsX[2], 2) + Math.Pow(CoordsY[3] - CoordsY[2], 2));

            if (f > max)
            {
                max = f;
            }

            Console.WriteLine("La distancia mayor es: " + max);
        }
    }
}
