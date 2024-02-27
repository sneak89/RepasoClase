using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Negocio
    {
        //Atributos 
        public string nombre;
        public string direccion;
        public int telefono;

        public Negocio(string nombre, string direccion, int telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }
    }
}
