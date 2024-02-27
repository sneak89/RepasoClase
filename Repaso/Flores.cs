using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Flores
    {
                /*Atributos 
        Al colocar el get y el set se 
        "brinda" un grado mas de proteccion
        ademas se puede colocar el valor de
        inicializacion en las mismas.  
        Palabra reservada prop
        */

        public string especie { get; set; }
        public string color { get; set; }
        public double tamaño { get; set; }
        public double precio { get; set; }

        //Constructor
        public Flores(string especie, string color, double tamaño, double precio)
        {
            this.especie = especie;
            this.color = color;
            this.tamaño = tamaño;
            this.precio = precio;
        }

        //Metodos
        public bool hacerRamo(bool condicion)
        {
            //El tipo de dato Bool solo puede ser 
            //Verdadero o falso
            if(condicion)
            {
                Console.WriteLine("El valor es verdadero TRUE");
            }
            else
            {
                Console.WriteLine("El valor es falso FALSE");
            }
            return condicion;
        }

    }
}
