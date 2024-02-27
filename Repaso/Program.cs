// See https://aka.ms/new-console-template for more information
//Repaso de generar clases 
//Ejemplo de una Persona que trabaja vendiendo flores
/*Atributos clase persona: 
 *  Nombre
 *  Edad
 *  Telefono
 * Metodos clase persona:
 *  Camine
 *  Trabaje
 *  -----------------------------
 * Atributos clase negocio:
 *  Nombre
 *  Direccion
 *  Telefono
 *  -----------------------------
 * Atributos clase flores:
 *  Especie
 *  Color
 *  Tamaño
 *  Precio
 * Método clase flores: 
 *  Hacer ramo
 -----------------------------------------------*/

using Repaso;//Nombre de espacio del proyecto (Libreria)

//Variables
string seleccion = "";
bool condicion; 
//Instancia del objeto 
Persona persona1 = new Persona("Juan", 19, 276123456);
Flores flores = new Flores("Rosa", "Roja", 10, 30); 

//Acceso a los metodos del objeto persona 1
persona1.Caminar();
persona1.Trabajar(); 

Console.WriteLine("El cliente quiere un arreglo (Si.- S, No.- N)");
seleccion = Console.ReadLine();
if(seleccion == "S")
{
    condicion = true;
}
else
{
    condicion = false; 
}

flores.hacerRamo(condicion); 
