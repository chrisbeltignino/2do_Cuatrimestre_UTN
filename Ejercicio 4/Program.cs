using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int numero = 1;

            while (contador < 5)
            {
                if (ValidadorPerfecto.EsNumeroPerfecto(numero))
                {
                    Console.WriteLine("El numero {0} es perfecto {1}", contador, numero);
                    contador++;
                }

                numero++;
            }
            Console.ReadLine();
            /*
            int num = 1;
            int contador;

            for(int i=1; i<100000; i++)
            {
                contador = 0;
                for (int d=1; d<i; d++)
                {
                    if ((i % d) == 0)
                    {
                        contador = contador + d;
                    }
                }

                if (contador == i)
                {
                    Console.WriteLine("El numero {0} es perfecto {1}", num, i);
                    num++;
                }
                if(num == 5)
                {
                    break;
                }
            }
            Console.ReadLine();
            */
        }
    }
}
