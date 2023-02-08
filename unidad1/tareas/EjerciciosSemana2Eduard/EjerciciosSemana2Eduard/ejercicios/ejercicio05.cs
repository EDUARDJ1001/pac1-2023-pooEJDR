using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana2Eduard.ejercicios
{
    internal class ejercicio05
    {
        public ejercicio05()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("¿Pizza o Hamburguesa?");
                Console.WriteLine("_____________________");

                Console.WriteLine("¿Que desea ordenar?");
                Console.WriteLine("\n1. Hamburguesa\n2. Pizza\n\n");
                Console.Write("Seleccione su opcion: ");
                int eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine("El precio de las hamburguesas es: \n" +
                            "Hamburguesa des con papas ------------------------- L.95\n" +
                            "Hamburguesa de pollo con papas -------------------- L.90");
                        break;
                    case 2:
                        Console.WriteLine("El precio de las pizzas es:\n" +
                            "Pizza de Jamon ------------------------- L.115\n" +
                            "Pizza de Pepperonni -------------------- L.125\n" +
                            "Pizza estilo casero -------------------- L.150\n");
                        break;
                    default: 
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.WriteLine("¿Desea volver a consultar opciones? (S: si /N: no)");
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
