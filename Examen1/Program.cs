using System;

namespace SimulacroExamen1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimulacroExamen
            // 1 - Ejercicio
            //     Hacer un programa que calcule una venta de dólares de la siguiente manera: Solicita 
                // la cotizacion del dolar Solicita la cantidad de dólares a comprar Calcula el precio en 
                // pesos utilizando la cotización y sumandole un 5% en concepto de comisión Imprime el 
                // monto en pesos a pagar.

            Console.WriteLine("Escriba cotización del dólar:"); 
            decimal cotizacionDolar = Convert.ToDecimal(Console.ReadLine()); 
            Console.WriteLine("Escriba cantidad de dólares a comprar; ");
            decimal cantAComprar = Convert.ToDecimal(Console.ReadLine());

            decimal montoAPagar = 0;
            Solucion valorAPagar = new Solucion();
            montoAPagar = valorAPagar.ValorDeCompra(cantAComprar, cotizacionDolar); 

            Console.WriteLine($"El monto a abonar es de: {montoAPagar.ToString()}"); 


            // 2 - Ejercicio
            //     Crear una matriz de n * m filas (cargar n y m por teclado) de enteros. Informar por 
                    // consola el mayor elemento y la fila y columna donde se almacena su primera aparición.
            Console.WriteLine("Escriba dimensión de 'n':"); 
            int iDimesionN = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Escriba dimensión de 'm'; ");
            int iDimensionM = Convert.ToInt32(Console.ReadLine());
            

            int[,] aMatriz = new int[iDimesionN, iDimensionM];

            for (int i = 0; i < iDimesionN; i++) 
            {
                for (int j = 0; j < iDimensionM; j++)
                {
                Console.WriteLine("Escriba un número para la fila: " + Convert.ToString(i) + " y la columna: " + Convert.ToString(j));
                aMatriz[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            SolucionE2 Sol2 = new SolucionE2();
            string sValAEscr = ""; 
            sValAEscr = Sol2.ResultadoE2(aMatriz); 
        
            Console.WriteLine(sValAEscr); 


            





            // 3 - Ejercicio
            //     Plantear un modelo de Figuras que permita representar rectangulos y triangulos. Toda 
                    // figura tiene un nombre. Implementar el cálculo del área. Implementar el calculo del 
                    // perimetro.
            //     Hacer un programa que cree dos triángulos y un rectángulo, agruparlos en una lista. 
                    // Recorrer la lista y, por cada elemento, informar por consola area y perimetro.
            // 4 - Que son el CLR y el BCL
            // 5 - Por que el método Main es static ?
            // 6 - Para qué sirve la sentencia using. Dar un ejemplo.
//            Console.WriteLine("Hello World!");
        }
    }
}
