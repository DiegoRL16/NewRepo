using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EjemplosDeClase
{
    /// <summary>
    /// Programa que permita ingresar tres valores por teclado
    /// Luego mostrar el mayor y el menor
    /// </summary>
    class EspacioMayorMenor
    {
        //Metodo sin parametros que permite cargar los valores (3)
        public void CargarValores()
        {
            //Declarar las variables
            int a, b, c;
            int mayor, menor;

            //Asignar los valores a las variables
            Console.Write("Ingrese primer valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese tercer valor: ");
            c = Convert.ToInt32(Console.ReadLine());

            mayor = CalcularMayor(a, b, c); //Mando llamar el metodo para el mayor
            menor = CalcularMenor(a, b, c); //Mando llamar el metodo menor

            Console.WriteLine("El valor mayor de los tres es: " + mayor);
            Console.WriteLine("El valor menor de los tres es: " + menor);
        }

        /// <summary>
        /// Metodo con parametros que retorna valor, para calcular el mayor de ellos
        /// </summary>
        /// <param name="v1">Valor a</param>
        /// <param name="v2">Valor b</param>
        /// <param name="v3">Valor c</param>
        /// <returns>El numero mayor de los tres (a, b, c)</returns>

        public int CalcularMayor(int v1, int v2, int v3)
        {
            int mayor;

            if (v1 > v2 && v1 > v3)
            {
                mayor = v1;
            }
            else
            {
                if (v2 > v3)
                {
                    mayor = v2;
                }
                else
                {
                    mayor = v3;
                }
            }

            return mayor; // Regresando el numero mayor porque lo guarde en esta variable
        }

        /// <summary>
        /// Metodo con parametros que retorna valor, para calcular el menor de los numeros
        /// </summary>
        /// <param name="v1">Valor a</param>
        /// <param name="v2">Valor b</param>
        /// <param name="v3">Valor c</param>
        /// <returns>El numero menor de los tres (a, b, c)</returns>
        public int CalcularMenor(int v1, int v2, int v3)
        {
            int menor;

            if (v1 < v2 && v1 < v3)
            {
                menor = v1;
            }
            else
            {
                if (v2 < v3)
                {
                    menor = v2;
                }
                else
                {
                    menor = v3;
                }
            }

            return menor; // Regresando el numero menor porque lo guarde en esta variable
        }

        static void Main(string[] args)
        {
            EspacioMayorMenor emm = new EspacioMayorMenor();
            emm.CargarValores();

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
