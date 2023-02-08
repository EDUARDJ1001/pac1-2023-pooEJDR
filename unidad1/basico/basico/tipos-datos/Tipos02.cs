using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.tipos_datos
{
    internal class Tipos02
    {
        public Tipos02()
        {
            // Ejemplo con String => cadena de Caracteres
            Console.WriteLine("Coloque o ingrese su nombre: ");
            String nombre = Console.ReadLine();

            // Ejemplo con Int => valores enteros o numericos
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su edad: ");

            //Boolean
            Console.WriteLine("Ingrese su genero: ");
            bool genero = bool.Parse(Console.ReadLine());

            //Salidas de texto
            Console.WriteLine("El nombre ingresado es: " + nombre);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su genero es: " + genero);

            //Fechas
            //DateTime

            
        }
    }
}
