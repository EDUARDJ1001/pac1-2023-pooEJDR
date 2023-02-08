using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2Eduard.ejercicios
{
    internal class ejercicio06
    {
        public ejercicio06()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Numero en consola hasta el 100 con ciclo for");
                Console.WriteLine("____________________________________________\n\n");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();

                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("¿Desea volver a ejecutar el programa? (S: si /N: no)");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta != "S")
                {
                    continuar = false;
                }
                Console.Clear();
            }
        }
    }
}
