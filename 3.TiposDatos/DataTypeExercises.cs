using System;

namespace CSharpExercises{
    public class DataTypeExercises{
        public void ValueSum(){
            Console.WriteLine("Ingrese un valor a sumar:");
            var firstValue =  Console.ReadLine();

            Console.WriteLine("Ingrese otro valor a sumar:");
            var secondValue = Console.ReadLine();

//con control de errores 
//            int first = Int32.Parse(firstValue);
//            int second = Int32.Parse(secondValue);

            int first = 0;
            int second =0;
            bool couldParseFirst = Int32.TryParse(firstValue, out first);

            if (couldParseFirst) {

                bool couldParseSecond = Int32.TryParse(secondValue, out second);

                if (couldParseSecond) {

                    Console.WriteLine("El resultado de la suma es: {0}", first + second);

                }
                else
                {
                    Console.WriteLine("El segundo valor no es numérico");
                }

            }
            else
            {
                Console.WriteLine("El primer valor no es numérico");
            }

        }
    }
}