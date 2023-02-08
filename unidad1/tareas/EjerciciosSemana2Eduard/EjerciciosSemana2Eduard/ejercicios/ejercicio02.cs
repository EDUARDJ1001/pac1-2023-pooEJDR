using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2Eduard.ejercicios
{
    internal class ejercicio02
    {
        public ejercicio02()
        {            
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Programa para determinar cual numero es mayor.");
                Console.WriteLine("______________________________________________\n");

                Console.Write("Ingrese el numero a: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el numero b: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("El numero a es mayor que el numero b.");
                }
                else if (num2 > num1)
                {
                    Console.WriteLine("El numero b es mayor que el numero a.");
                }
                else 
                {
                    Console.WriteLine("Ambos numeros tienen el mismo valor.");
                }
               
                Console.WriteLine("¿Desea continuar? (S/N)");
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
