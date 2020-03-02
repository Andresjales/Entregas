using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de votos por el partido 1: ");
            int votos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos por el partido 2: ");
            int votos2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos en blanco: ");
            int votosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos anulados: ");
            int votosA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de habitantes: ");
            double habitantes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje (0-100%) de habitantes que son mayores de edad: ");
            double pMayores = double.Parse(Console.ReadLine());

            double votosTotales = votos1 + votos2 + votosA + votosB;
            double diferencia = 0;
            if (votos1 > votos2)
            {
                diferencia = votos1 - votos2;
            }
            else
            {
                diferencia = votos2 - votos1;
            }

            bool A = votosTotales > habitantes;
            bool B = diferencia < (votosTotales * 0.1);
            bool C = votosTotales < (habitantes * 0.3);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            if ((A || B) && C)
            {
                Console.WriteLine("Las elecciones deben realizarse nuevamente.");
            }
            else
            {
                if (votos1 > votos2)
                {
                    Console.WriteLine("El ganador fue el partido 1.");
                }
                else
                {
                    Console.WriteLine("El ganador fue el partido 2.");
                }
            }
        }
    }
}
