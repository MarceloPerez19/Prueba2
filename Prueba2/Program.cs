using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Esta es una prueba para manual GIT");
            Console.ReadKey();


            //Saludos desde la PUCESE
            Console.WriteLine("BIENVENIDO A LA PUCESE");
            Console.WriteLine("SEGUNDO DE TIC");

            //Fin de clase
            Console.WriteLine("Time is over...");

            Console.WriteLine("Probando la funcion");
            int suma = funcionSuma(10, 20);
            Console.WriteLine("Resultado funcion = {0}", suma);

            Console.ReadKey();
        }

        //funcion suma
        public static int funcionSuma(int a, int b)
        {
            return (a * 10 + b * 100);

        }
    }
}
