using Cuentas;
using System;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Juan Perez", 1000);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Ingresar(500);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(200);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(1500);
            Console.WriteLine(cuenta.Mostrar());

            Console.ReadKey();
        }
    }
}
