using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2Eduard.ejercicios
{
    internal class ejercicio03
    {
        public ejercicio03()
        {
            Console.WriteLine("¿Cual es su genero?");
            Console.WriteLine("___________________\n");

            Console.WriteLine("¿Cual es su genero?");
            Console.Write("Escriba 1 si es hombre o 2 si es mujer: ");
            int genero = int.Parse(Console.ReadLine());

            if (genero == 1)
            {
                Console.WriteLine("Eres hombre (Masculino)");
            }
            else if (genero == 2)
            {
                Console.WriteLine("Eres mujer (Femenino)");
            }
            else
            {
                Console.WriteLine("Genero no valido");
            }
        }
    }
}
