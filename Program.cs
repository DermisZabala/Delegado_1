using System;
using System.Collections.Generic;

namespace Delegados_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Delegado_1 ElDelegado = new Delegado_1(Personas.DatosPersona);

            Console.WriteLine(ElDelegado("Hamel", 19));
            Console.WriteLine(ElDelegado("Juan", 30));

            ElDelegado = new Delegado_1(Animal.DatosAnimal);

            Console.WriteLine(ElDelegado("CHIVI", 3));
            Console.WriteLine(ElDelegado("BOLA NEGRA", 5));


            Console.ReadKey();

        }

        delegate string Delegado_1(string nombre, int edad);

    }
    class Personas
    {
        public static string DatosPersona(string nombre, int edad)
        {
            return "Nombre de la persona: " + nombre + " \tEdad: " + edad;
        }
    }
    class Animal
    {
        public static string DatosAnimal(string nombre, int edad)
        {
            return "Nombre del animal: " + nombre + " \tEdad: " + edad;
        }
    }
}
