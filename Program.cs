using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dado1 = 0, dado2 = 0, total = 0, vidas = 3, turnos = 0, turno2 = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                turnos++;
                turno2++;
                if (turnos %2 == 0)
                {
                    vidas--;
                }

                if (vidas == 0)
                {
                    Console.WriteLine("Lo siento, te quedaste sin vidas.");
                        break;
                }

                Console.WriteLine("Turno " + turnos + " Vidas " + vidas);

                if (turno2 == 3)
                {
                    dado1 = rnd.Next(1, 13);
                    dado2 = rnd.Next(1, 13);
                    Console.WriteLine("Dado 1 = " + dado1 + " Dado 2 = " + dado2);
                    if (dado1 == dado2)
                    {
                        vidas++;
                        Console.WriteLine("¡Felicidades, conseguiste una vida!");
                    }
                    total += dado1 + dado2;
                    turno2 = 0;
                    Console.WriteLine("Total = " + total);
                    Console.WriteLine("¿Desea continuar? (s/n): ");
                    continuar = Console.ReadLine();
                }
                else
                {
                    dado1 = rnd.Next(1, 13);
                    Console.WriteLine("Dado = " + dado1);
                    total += dado1;
                    Console.WriteLine("Total = " + total);
                    Console.WriteLine("¿Desea continuar? (s/n): ");
                    continuar = Console.ReadLine();
                }

                if (total >= 100)
                {
                    Console.WriteLine("¡Ganaste!");
                    continuar = "n";
                }
            }

            Console.WriteLine("Gracias por jugar. Su total fue de " + total + " puntos.");
        }
    }
}
