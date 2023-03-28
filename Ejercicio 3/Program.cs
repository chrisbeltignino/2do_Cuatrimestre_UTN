using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool operar = true;

            while (operar)
            {
                Console.Write("Ingrese un número o escriba 'salir' para terminar: ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "salir")
                {
                    return;
                }

                if (!int.TryParse(entrada, out int num))
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero o escriba 'salir' para terminar.");
                    continue;
                }

                Console.WriteLine($"Los números primos hasta {num} son:");

                for (int i = 2; i <= num; i++)
                {
                    if (ValidadorPrimo.EsPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.Write("¿Desea volver a operar? (S/N): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s")
                {
                    operar = false;
                }
            }
            /*
            int numero;
            int n = 2;
            int total = 1;
            int opcion;
            Boolean salir = false;

            do
            {
                Console.Write("1- Ingresar primos.\n" +
                              "2- Salir.\n");
                Console.Write("Ingresar opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Mostar cantidad de numero primos: ");
                        numero = int.Parse(Console.ReadLine());

                        while (numero <= 0)
                        {
                            Console.Write("ERROR. ¡Reingresar número!: ");
                            numero = int.Parse(Console.ReadLine());
                        }

                        while (total <= numero)
                        {
                            Boolean esPrimo = true;

                            for (int i = 2; i < n; i++)
                            {
                                if (n % i == 0)
                                {
                                    esPrimo = false;
                                    break;
                                }
                            }

                            if (esPrimo)
                            {
                                Console.WriteLine(n);
                                total++;
                            }
                            n++;
                        }
                        Console.ReadLine();
                    break;

                    case 2:
                        salir = true;
                    break;
                    default:
                        Console.WriteLine("ERROR. ¡Reingresar número!: ");
                    break;
                }
            } while (salir == false);
            */
        }
    }
}
