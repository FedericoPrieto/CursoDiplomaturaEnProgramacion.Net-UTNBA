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

            if (nombre == nombre1)
            {
                Console.WriteLine("Los nombres son iguales");

            }
            else {

                Console.WriteLine("Los nombres son distintos");

            }

            //string [] temp= {nombre}; 
            //Array.Reverse(temp);
            
            Console.Write("[ ");
            for (int i = nombre.Length - 1; i >= 0; i--)
            {
                // if (i > 0)
                // {
                //     Console.Write(",");
                // }
                Console.Write(nombre[i]);
            }
            Console.WriteLine("]");


        }
    }
}
