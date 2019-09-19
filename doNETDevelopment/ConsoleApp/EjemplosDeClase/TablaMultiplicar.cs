using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EjemplosDeClase
{
    /// <summary>
    /// Programa que permita ingresar valores entero por teclado y nos muestre la tabla de multiplicar
    /// de dicho valor, finaliza el programa al ingresar el -1
    /// </summary
    class TablaMultiplicar
    {
        //Metodo sin parametros, que permite cargar los valores
        public void CargarValor() //Sin parametro --> Viene vacio aqui
        {
            //Declarar variables
            int valor;

            do
            {
                //Asignar valores a las variables
                Console.Write("Ingrese un valor (-1 para finalizar): ");
                valor = Convert.ToInt32(Console.ReadLine());

                //Validar que sea diferente de -1
                if (valor != -1)
                {
                    Calcular(valor); //Manda llamar el metodo de calcular
                }

            } while (valor != -1);
        }

        /// <summary>
        /// Metodo con parametros que permita calcular la Tabla de Multiplicar
        /// </summary>
        /// <param name="v">Numero que se estara multiplicando</param>
        public void Calcular (int v) //Con parametros --> Viene con informacion
        {
            for (int i = v; i <= v * 10; i = i + v)
            {
                Console.Write(i + "-");
            }

            Console.WriteLine();
        }

        //static void Main (string[] args)
        //{
        //    TablaMultiplicar tm = new TablaMultiplicar(); //Se le como instancia de una clase
        //    tm.CargarValor();
        //}
    }
}
