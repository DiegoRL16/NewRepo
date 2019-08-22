using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EjemplosDeClase
{
    /// <summary>
    /// Programa para ingresar el sueldo de una persona, si supera los 3000 pesos
    /// mostrar un mensaje en pantalla indicando que debe abonar impuestos.
    /// </summary>
    class EstructuraCondicionalSimple
    {
        static void Main (string[] args)
        {
            //Declarar las variables
            float sueldo;

            //Preguntar el sueldo de la persona
            Console.Write("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());

            //Hacer la condicional para validar el sueldo, por condicional
            if (sueldo > 3000)
            {
                //(1) SALIDA: --> Verdadero
                Console.WriteLine("Esta persona debe abonar impuestos");
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
