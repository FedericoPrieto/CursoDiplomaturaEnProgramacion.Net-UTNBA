using System;

namespace EjerciciosVarios.Simulacro.Examen
{
    public class Ejercicio1
    {
        //     Hacer un programa que calcule una venta de dólares de la siguiente manera: Solicita 
        // la cotizacion del dolar Solicita la cantidad de dólares a comprar Calcula el precio en 
        // pesos utilizando la cotización y sumandole un 5% en concepto de comisión Imprime el 
        // monto en pesos a pagar.        
       public void ejercicio1()
       {
            Console.WriteLine("Cuál es la cotización del dolar?:");
            string cotizacionDolar = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de dólares a comprar:");
            string cantCompra = Console.ReadLine(); 
            Double precioTotal = (Convert.ToDouble(cotizacionDolar) * Convert.ToDouble(cantCompra)) * 1.05;
            Console.WriteLine($"El valor en pesos es {precioTotal}");  
            Console.ReadLine();
        }



    }
}