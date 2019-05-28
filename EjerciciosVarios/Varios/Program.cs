using System;

namespace EjerciciosVarios.Varios
{
    class Program
    {
        static void Main(string[] args)
        {
            Varios1 varios1 = new Varios1(); 
            int var = 1054;
            Console.WriteLine($"El número ingresado es {var} y el número convertido a binario es {Convert.ToString(var, 2)}");
            Console.WriteLine($"El número máximo de ceros consecutivos es {varios1.ContCeros(var)}");
        }
    }
}
