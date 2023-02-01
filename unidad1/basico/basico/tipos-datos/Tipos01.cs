using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basico.tipos_datos;

namespace basico.tipos_datos
{
    internal class Tipos01
    {
        public String saludo { get; set; }

        public Tipos01(String v1) 
        {
            this.saludo = v1;
            String sNombre = this.saludo + ", Juan Perez";

            Console.WriteLine(sNombre);
        }
    }
}
