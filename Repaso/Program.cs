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

//Instancia del objeto 
Persona persona1 = new Persona("Juan", 19, 276123456);

//Acceso a los metodos del objeto persona 1
persona1.Caminar();
persona1.Trabajar(); 
