using System;

namespace CSharpExercises{
    public class ConsoleExercises {
        public void AskAge(){

            Console.WriteLine("¿Cuántos años tenes?: ");
            string age = Console.ReadLine();
            Console.WriteLine("Wow, no pareces de " + age + " años");

 //Pedir nombre, apellido y documento e imprimir toda la información al final.
            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu apellido");
            string apellido = Console.ReadLine();

            Console.WriteLine("Escribe tu DNI");
            string dni = Console.ReadLine();

            Console.WriteLine("Tu nombre es {0}, tu apellido es {1} y tu DNI es {2}", nombre, apellido, dni);

            Console.ReadLine();
        }
    }
}