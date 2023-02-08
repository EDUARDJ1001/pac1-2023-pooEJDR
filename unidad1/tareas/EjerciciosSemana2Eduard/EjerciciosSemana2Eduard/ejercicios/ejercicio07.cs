using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2Eduard.ejercicios
{
    internal class ejercicio07
    {
        public ejercicio07()
        {
            bool continuar = true;

            while (continuar)
            {                      
                int suma = 0;

                for (int i = 1; i <= 10; i++)
                {
                    suma += i;
                    Console.WriteLine(i);                    
                }

                Console.WriteLine("Presione cualquier tecla para realizar la suma\n");
                Console.ReadKey();
                Console.WriteLine("La suma de los numeros del 1 al 10 es: " + suma);

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
