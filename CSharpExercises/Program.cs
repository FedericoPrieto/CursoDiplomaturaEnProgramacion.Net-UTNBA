using System;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Escriba el número de ejercicio:");
            string x = System.Console.ReadLine();

            switch(x){
            case "1":
                    //1.
                    ConsoleExercises console = new ConsoleExercises();
                    console.AskAge();
                    break;
            //Pedir nombre, apellido y documento e imprimir toda la información al final.

            case "2":
                    //2.
                    VariableExercises variable = new VariableExercises();
                    variable.Concatenador();
                    break;
            
            case "3":
                    //3.
                    DataTypeExercises dataType = new DataTypeExercises();
                    dataType.ValueSum();
                    break;
            default:
                    System.Console.WriteLine("No existe ejercicio");
                    break;

            }
        }
    }
}
