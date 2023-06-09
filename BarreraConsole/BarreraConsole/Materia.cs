using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarreraConsole
{
    public class Materia
    {
        public string Nombre { get; set; }
        public string Carrera { get; set; }

        public Materia(string nombre, string carrera)
        {
            Nombre = nombre;
            Carrera = carrera;
        }


    }
}
