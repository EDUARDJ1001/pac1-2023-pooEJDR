using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumero01
    {
        public ListarNumero01()
        {
            /*
             *while(condicion) {...}
             */

            bool continuarlistando = true;

            while (continuarlistando)
            { 
                Console.WriteLine("Listar numero hasta: ");
                int limite = int.Parse(Console.ReadLine());
                int i = 1;

                while (i <= limite)
                {
                    Console.WriteLine(i);
                    i++;
                }
                Console.WriteLine("¿Desea continuar listando números? (S/N)");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta != "S")
                {
                    continuarlistando = false;
                }
            }


        }
    }
}
