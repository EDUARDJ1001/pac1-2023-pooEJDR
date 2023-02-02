using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class Promedios
    {
        /*
         * Ingresar 3 notas
         *menos de 70 puntos => reprobado
         *mas de 70 puntos => aprobado
         *mas de 80 puntos => bueno
         *mas de 90 puntos => sobresaliente
         *
         */
        public Promedios()
        {
            Console.WriteLine("Promedio de notas");

            Console.WriteLine("Ingrese la 1ra nota: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la 2da nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la 2da nota: ");
            int nota3 = int.Parse(Console.ReadLine());

            float promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio de notas es: " + promedio);

            if (promedio < 70)
            {
                Console.WriteLine("Reprobado");
            }
            if (promedio >= 70)
            {
                Console.WriteLine("Aprobado");
            }
            if (promedio >= 80)
            {
                Console.WriteLine("Bueno");
            }
            if (promedio >= 90)
            {
                Console.WriteLine("Sobresaliente");
            }




        }
    }
}
