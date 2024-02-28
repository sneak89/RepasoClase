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
        public double ingresosDia;
        public double gastos; 

        //Constructor
        public Persona(string nombre, int edad, int telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
            Console.WriteLine("Coloca el ingreso por dia: ");
            ingresosDia = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el gasto por mes: "); 
            gastos = double.Parse(Console.ReadLine());  
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

        //Sobrecarga de métodos
        public void Ganancia()
        {
            Console.WriteLine("La ganancia es: $1434324");
        }

        public void Ganancia(double ingreso, double gasto)
        {
            double ganancia = 0;
            ganancia = (ingreso * 30) - gasto;
            Console.WriteLine("La ganancia es: " + ganancia); 
        }

        public double Ganancia(double ingre, double gast, int dias)
        {
            double gan = 0;
            gan = (ingre * dias) - gast;
            return gan;
        }
    }
}
