using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine("Ingrese el número de jugadores (min 2/max 5): ");
            int n = int.Parse(Console.ReadLine());

            while (n < 2 || n > 5)
            {
                Console.WriteLine("Error. Número de jugadores invalido.");
                Console.WriteLine("Ingrese el número de jugadores (min 2/max 5): ");
                n = int.Parse(Console.ReadLine());
            }

            int jugador = 1;
            int min = 100, max = 0;
            int jugadorMin = 0, jugadorMax = 0;

            while (jugador <= n)
            {
                Console.WriteLine("\n\nBienvenido jugador " + jugador);
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

                while (tomar != "s" && tomar != "n")
                {
                    Console.WriteLine("Respuesta invalida.");
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
                        total = 0;
                        tomar = "n";
                    }
                    else
                    {
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("¿Desea tomar más? (s/n): ");
                        tomar = Console.ReadLine();
                        while (tomar != "s" && tomar != "n")
                        {
                            Console.WriteLine("Respuesta invalida.");
                            Console.WriteLine("¿Desea tomar más? (s/n): ");
                            tomar = Console.ReadLine();
                        }
                    }
                }

                if (total < min)
                {
                    min = total;
                    jugadorMin = jugador;
                }

                if (total > max)
                {
                    max = total;
                    jugadorMax = jugador;
                }
                Console.WriteLine("Su total fue: " + total + " puntos.");
                Console.WriteLine("Gracias por participar.");
                jugador++;
            }

            Console.Write("\nEl ganador fue el jugador " + jugadorMax);
            Console.Write(" y el que obtuvo menos puntos fue el jugador " + jugadorMin);
        }
    }
}
