using System;
using CSharpExercises;


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
        
            case "01.":
                        // 01.
                        // Write a C# Sharp program to print Hello and your name in a separate line.
                        // Expected Output : Hello: Iván Franco
                        Exercise01 pepe = new Exercise01();
                        pepe.Exercise();
                        break;

            case "02.":
                        // 02.
                        // Write a C# Sharp program to print the sum of two numbers.
                        Exercise02 exercise02 = new Exercise02();
                        exercise02.cerodospunto();
                        break;


            default:
                    System.Console.WriteLine("No existe ejercicio");




// 03.
// Write a C# Sharp program to print the result of dividing two numbers.

// 04.
// Write a C# Sharp program to print the result of the specified operations.
// Test data:
// -1 + 4 * 6 -> Expected Output: 23
// ( 35+ 5 ) % 7 -> Expected Output: 5
// 14 + -4 * 6 / 11 -> Expected Output: 12
// 2 + 15 / 6 * 1 - 7 % 2 -> Expected Output: 3
		
// 05.
// Write a C# Sharp program to swap two numbers.
// Test Data:
// Input the First Number : 5
// Input the Second Number : 6
// Expected Output: 
// After Swapping :
// First Number : 6 
// Second Number : 5

// 06.
// Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
// Test Data:
// Input the first number to multiply: 2
// Input the second number to multiply: 3
// Input the third number to multiply: 6
// Expected Output:
// 2 x 3 x 6 = 36

// 07.
// Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
// Test Data:
// Input the first number: 25
// Input the second number: 4
// Expected Output:
// 25 + 4 = 29
// 25 - 4 = 21
// 25 x 4 = 100 
// 25 / 4 = 6
// 25 mod 4 = 1

// 08.
// Write a C# Sharp program that takes a number as input and print its multiplication table.
// Test Data:
// Enter the number: 5
// Expected Output:
// 5 * 0 = 0
// 5 * 1 = 5
// 5 * 2 = 10 
// 5 * 3 = 15
// ....
// 5 * 10 = 50

// 09.
// Write a C# Sharp program that takes four numbers as input to calculate and print the average.
// Test Data:
// Enter the First number: 10 
// Enter the Second number: 15 
// Enter the third number: 20 
// Enter the four number: 30 

// Expected Output:
// The average of 10 , 15 , 20 , 30 is: 18

// 10.
// Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
// Test Data:
// Enter first number - 5
// Enter second number - 6
// Enter third number - 7

// Expected Output:
// Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72

// 11.
// Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". 
// Test Data:
// Enter your age - 25
// Expected Output:
// You look older than 25

// 12.
// Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
// Test Data:
// Enter a digit: 25 
// Expected Output:
// 25 25 25 25 
// 25252525 
// 25 25 25 25 
// 25252525

// 13.
// Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
// Test Data:
// Enter a number: 5 
// Expected Output:
// 555 
// 5 5
// 5 5 
// 5 5 
// 555

// 14.
// Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
// Test Data:
// Enter the amount of celsius: 30
// Expected Output:
// Kelvin = 303
// Fahrenheit = 86

// 15.
// Write a C# program remove specified a character from a non-empty string using index of a character.
// Test Data:
// ivanfranco
// Sample Output:
// vanfranco
// vanfranc
// vanranc

// 16.
// Write a C# program to create a new string from a given string where the first and last characters will change their positions. 
// Test Data:
// ivanfranco
// Python
// Sample Output:
// ovanfranci
// nythoP 

// Vectores

// 17.
//  Ingresar x números enteros por consola, almacenarlos en un vector. Luego imprimir el vector (con while/ do-while)

// 18.
//  Ingresar x números enteros por consola. Luego pedir un numero a buscar por consola. Imprimir la cantidad de veces que aparece el número buscado en el conjunto de números previamente ingresado

// 19.
// Ingresar una cantidad x por consola. Luego ingresar x números enteros. Pedir un numero a buscar por consola. Imprimir en cuáles solicitudes se ingresó ese número.

// Ej: 
// Ingresar una cantidad: 4
// Ingresar un número: 3
// Ingresar un número: 7
// Ingresar un número: 7
// Ingresar un número: 5
// Buscar: 7

// Resultado:
// 7 se ingresó en las solicitudes: 2,3.




                    break;

            }
        }
    }
}
