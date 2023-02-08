using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2Eduard.ejercicios
{
    internal class ejercicio01
    {
        public ejercicio01()
        {
            bool continuar = true;

            while (continuar) 
            {
                Console.WriteLine("Programa para determinar si el numero ingresado es positivo, negativo o cero.");
            Console.WriteLine("_____________________________________________________________________________\n");

                Console.Write("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("El numero ingresado es POSITIVO.");
                }
                if (num < 0)
                {
                    Console.WriteLine("El numero ingresado es NEGATIVO.");
                }
                if (num == 0)
                {
                    Console.WriteLine("El numero ingresado es CERO.");
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
