using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2Eduard.ejercicios
{
    internal class ejercicio04
    {
        public ejercicio04()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Dias de la semana segun numero");
                Console.WriteLine("______________________________");

                Console.Write("Ingrese un numero del 1 al 7: ");
                int numeroDia = int.Parse(Console.ReadLine());

                switch (numeroDia)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    default:
                        Console.WriteLine("El número que ingresó no es válido");
                        break;
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
