using System;

namespace CSharpExercises
{
    public class Exercise02
    {
        public void cerodospunto() 
        {
            // 02.
            // Write a C# Sharp program to print the sum of two numbers. 
            Console.WriteLine("Escriba un número");
            int numero1 = Int32.Parse(Console.ReadLine()); 

            Console.WriteLine("Escriba otro número");
            int numero2 = Int32.Parse(Console.ReadLine()); 

            int total1y2 = numero1 + numero2;  

            Console.WriteLine("La suma de {0} con {1} es: {2}", numero1, numero2, total1y2);

            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();
        }

    }
}