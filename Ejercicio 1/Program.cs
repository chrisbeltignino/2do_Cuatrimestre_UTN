/*
    Consigna
    Realizar en C# una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

    bool Validar(int valor, int min, int max)

    valor: dato a validar.
    min: mínimo valor incluido.
    max: máximo valor incluido.
    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

    Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = 0;
            int maximo = 0;
            int acumulador = 0;
            float promedio;

            for (int i = 1; i < 10; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                numero = int.Parse(Console.ReadLine());

                if (Validador.Validar(numero, -100, 100))
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    acumulador += numero;
                }
                else
                {
                    Console.WriteLine("El número ingresado no está en el rango permitido (-100 a 100)");
                    i--; // Restar uno a i para repetir el ciclo con la misma posición
                }
            }
            promedio = (float)(acumulador / 10);

            Console.WriteLine($"El valor mínimo ingresado es: {minimo}");
            Console.WriteLine($"El valor máximo ingresado es: {maximo}");
            Console.WriteLine($"El promedio es: {promedio}");
            Console.ReadLine();
        }
    }
}