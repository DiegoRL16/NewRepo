using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tareas_7___EstructuraRepetitivaDoWhile
{
    /// <summary>
    /// Checar en bloc de Notas
    /// </summary>
    class Tarea2
    {

        // NDC = Numero de Cuenta
        // SA = Saldo Actual
        // SU = Suma
        static void Main(string[] args)
        {
            int NDC, SA, SU;

            SU = 0;

            do
            {
                Console.Write("Ingrese el Numero de Cuenta: ");
                NDC = Convert.ToInt32(Console.ReadLine());

                if (NDC >= 0)
                {
                    Console.Write("Ingrese el Saldo: $");
                    SA = Convert.ToInt32(Console.ReadLine());

                    if (SA > 0)
                    {
                        Console.WriteLine("Saldo Acreedor");
                        SU = SU + SA;
                    }
                    else
                    {
                        if (SA < 0)
                        {
                            Console.WriteLine("Saldo Deudor");
                        }
                        else
                        {
                            Console.WriteLine("Saldo Nulo");
                        }
                    }
                }

            } while (NDC >= 0);

            Console.WriteLine("Total de saldos Acreedores: $" + SU);

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
