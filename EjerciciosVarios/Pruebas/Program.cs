using System;

namespace Pruebas

   {
   class Program
    {
        static void Main(string[] args)
        {
            ImprimeArrayInvertido();
            CreaArray();

        }
        private static void ImprimeArrayInvertido()
        {
            int[] list = { 21, 73, 14, 24, 20, 3, 1 };
            int[] temp = new int[list.Length];
 

            Array.Copy(list, temp, list.Length);
 

            Console.WriteLine("Array Original: ");
            Utilidades.Show(list);
 
            Utilidades.Show(list);

            Array.Reverse(temp);
            Console.WriteLine("Array Invertido: ");
            Utilidades.Show(temp);
 
            Utilidades.Show(temp);

            Array.Sort(list);
            Console.WriteLine("Arreglo Ordenado: ");
            Utilidades.Show(list);

            Utilidades.Show(list);
        }

        //static void myArray()
        static void CreaArray()
        {
          
                int[] myArray = { 21, 73, 14, 24, 20, 3, 1 };
          
            Console.Write("[ ");
            for(int i=0; i < myArray.Length; i++)

            Console.WriteLine("Ingrese cant. de elementos");
            int cantidad = int.Parse(Console.ReadLine());

            int[] vector = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vector.Length; i++)
            {
                if(i > 0)
                for (int j = i + 1; j < vector.Length; j++)
                {
                    Console.Write(",");
                    if (vector[i] > vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
                Console.Write(myArray[i]);
            }
            Console.WriteLine("]");

            Console.WriteLine("Vector Ordenado: ");
            Utilidades.Show(vector);
            Console.ReadKey();

        }

    }
    }
