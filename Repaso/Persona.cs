using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Persona
    {
        //Atributos
        public string nombre;
        public int edad;
        public int telefono; 

        //Constructor
        public Persona(string nombre, int edad, int telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
        }

        //Metodos
        public void Caminar()
        {
            Console.WriteLine("La persona esta caminando");
        }

        public void Trabajar()
        {
            Console.WriteLine("La persona esta trabajando"); 
        }
    }
}
