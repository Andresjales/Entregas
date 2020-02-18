using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, turnos = 0, ant = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                ant = dado;
                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado = " + dado);
                total += dado;
                turnos++;

                if (ant == 10 && dado == 12 && turnos > 3)
                {
                    Console.WriteLine("Ganaste! Conseguiste un 12 seguido de un 10.");
                    continuar = "n";
                }
                else if (total >= 100)
                {
                    Console.WriteLine("Ganaste!");
                    continuar = "n";
                }
                else if (dado % 2 != 0 && turnos > 3)
                {
                    Console.WriteLine("Sacaste un impar. Perdiste.");
                    continuar = "n";
                }


                else
                {
                    Console.WriteLine("Total = " + total);
                    Console.WriteLine("¿Deasea continuar? (s/n): ");
                    continuar = Console.ReadLine();
                }
            }

            Console.WriteLine("Su total fue: " + total + " puntos.");
            Console.WriteLine("Gracias por participar.");
        }
    }
}
