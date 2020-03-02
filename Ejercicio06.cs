using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int cartas = 0, total = 0;
            string tomar = "s";

            if (total == 0)
            {
                cartas = aleatorio.Next(1, 11);
                Console.WriteLine("Sus dos primeras cartas son:  " + cartas);
                total += cartas;
                cartas = aleatorio.Next(1, 11);
                Console.WriteLine("y " + cartas);
                total += cartas;
                Console.WriteLine("Su total es: " + total);
                Console.WriteLine("¿Desea tomar más? (s/n): ");
                tomar = Console.ReadLine();
            }

            while (tomar == "s")
            {
                cartas = aleatorio.Next(1, 11);
                Console.WriteLine("Carta = " + cartas);
                total += cartas;
                if (total > 21)
                {
                    Console.WriteLine("Usted quedó eliminado.");
                    tomar = "n";
                }
                else
                {
                    Console.WriteLine("Total = " + total);
                    Console.WriteLine("¿Desea tomar más? (s/n): ");
                    tomar = Console.ReadLine();
                }
            }

            Console.WriteLine("Su total fue: " + total + " puntos.");
            Console.WriteLine("Gracias por participar.");
        }
    }
}
