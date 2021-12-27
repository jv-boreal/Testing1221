using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMPersona
{
    public class Personas
    {
        public string apellido = "";
        public string nombre = "";
        public string dni = "";
        public bool empleado = true;

        public Personas (string ap, string nom, string doc, bool emp)    
        {
            apellido = ap;
            nombre = nom;
            dni = doc;
            empleado = emp;
        }
    }
}

