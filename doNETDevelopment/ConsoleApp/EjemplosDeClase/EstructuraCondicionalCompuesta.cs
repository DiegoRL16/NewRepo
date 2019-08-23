using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EjemplosDeClase
{
    /// <summary>
    /// Programa que solicite ingresar 2 numeros distintos y muestre por pantalla
    /// el mayor de ellos.
    /// </summary>
    class EstructuraCondicionalCompuesta
    {
        static void Main (string[] args)
        {
            //Declarar variables
            int num1, num2;

            //Asignarles un valor
            Console.Write("Ingrese primer valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Validar cual de los dos es mayor
            if (num1 > num2)
            {
                //(1) SALIDA: Verdadero
                Console.WriteLine("El numero mayor es: " + num1);
            }
            else
            {
                //(2) SALIDA: Falso
                Console.WriteLine("El numero mayor es: " + num2);
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
