using System;

namespace Ejercicio_11
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

            string[] jugadores = new string[n];
            int[] puntaje = new int[n];
            int max = 0, segundo = 0;
            string jugadorMax = "", jugadorSeg = "";

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese su nombre: ");
                jugadores[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n\nBienvenido " + jugadores[i]);
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
                    while (tomar != "s" && tomar != "n")
                    {
                        Console.WriteLine("Respuesta invalida.");
                        Console.WriteLine("¿Desea tomar más? (s/n): ");
                        tomar = Console.ReadLine();
                    }
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

                puntaje[i] = total;

                Console.WriteLine("Su total fue: " + total + " puntos.");
                Console.WriteLine("Gracias por participar.");
            }

            for (int i = 0; i < n; i++)
            {
                if (puntaje[i] > max)
                {
                    max = puntaje[i];
                    jugadorMax = jugadores[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (segundo < puntaje[i] && puntaje[i] != max)
                {
                    segundo = puntaje[i];
                    jugadorSeg = jugadores[i];
                }
            }
            

            if (max == 0)
            {
                Console.Write("\nNo hubo ningun ganador.");
            }
            else
            {
                Console.Write("\nEl ganador es " + jugadorMax + " y el segundo lugar es para " + jugadorSeg);
            }
        }
    }
}
