using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class CondicionIf
    {
        public CondicionIf()
        {
            Console.WriteLine("Condición");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("\nIngrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            /*
             * Operadores Logicos en C#
             * == Comparar
             * > mayor que
             * < menor que
             * >= mayor o igual que
             * <= menor o igual que
             * != distinto
             * 
             * Compuertas logicas
             * && => AND o Y
             * || => OR ú O
             */

            if (edad >= 18)
            {
                Console.WriteLine("Usted mayor de edad");
            } else
            {
                Console.WriteLine("Usted es menor de edad");
            }

            if (edad >= 16 && edad <= 18)
            {
                Console.WriteLine("Sub-18");
            }
            else
            {
                Console.WriteLine("No entra en sub-18");
            }

        }
    }
}
