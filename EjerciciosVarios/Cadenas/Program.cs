using System;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
                // Escribir un programa que permita ingresar el nombre completo de una persona e Informe 
            //cuantos caracteres tiene este nombre.
                // Luego solicite el ingreso de una cadena de caracteres e informe si el nombre incluye 
            //o no esta cadena de caracteres.
                // Finalmente, que imprima el nombre al revés.
            Console.WriteLine("Escriba Nombre y Apellido");
            string nombre;
            nombre=Console.ReadLine();

            Console.WriteLine(nombre.Length);

            Console.WriteLine("Escriba Otro Nombre y Apellido");
            string nombre1;
            nombre1=Console.ReadLine();

            if (Console.WriteLine(nombre == nombre1))
            {

                Console.WriteLine("Los nombres son iguales");

            }
            Else {

                Console.WriteLine("Los nombres son distintos");

            }

        }
    }
}
