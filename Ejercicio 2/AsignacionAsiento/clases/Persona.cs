using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionAsiento.clases
{
    public class Persona
    {
        public string Name { get; set; }
        public int SelectNum { get; set; }
        public string Section { get; set; }

        public Persona(string nombre, int seleccionarNum, string seccion)
        {
            Name = nombre;
            SelectNum = seleccionarNum;
            Section = seccion;
        }
    }
}
