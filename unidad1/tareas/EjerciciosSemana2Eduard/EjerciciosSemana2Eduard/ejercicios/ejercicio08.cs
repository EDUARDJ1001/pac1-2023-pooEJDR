using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2Eduard.ejercicios
{
    internal class ejercicio08
    {
        public ejercicio08()
        {
            bool continuar = e;
            int numero;
            int resultado;

            public Factorial(int numero)
            {
                numero = num;
                resultado = 1;
                for (int i = 1; i <= numero; i++)
                {
                    resultado = resultado * i;
                }
            }

            public int getResultado()
            {
                return resultado;
            }

            Console.WriteLine("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Factorial f = new Factorial(num);
            Console.WriteLine("El factorial de " + num + " es " + f.getResult());
        }
    }
}
