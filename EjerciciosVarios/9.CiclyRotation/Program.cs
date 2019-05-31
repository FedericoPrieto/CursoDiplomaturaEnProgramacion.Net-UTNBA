using System;

namespace EjerciciosVarios._9.CiclyRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place. For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] (elements are shifted right by one index and 6 is moved to the first place).
            // The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.
            // Write a function:
            // class Solution { public int[] solution(int[] A, int K); }
            // that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.
            // For example, given
            // A = [3, 8, 9, 7, 6]
            // K = 3
            // the function should return [9, 7, 6, 3, 8]. Three rotations were made:
            // [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
            // [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
            // [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
            // For another example, given
            // A = [0, 0, 0]
            // K = 1
            // the function should return [0, 0, 0]

//            Console.WriteLine("Hello World!");
            Solution sol = new Solution();
            int[] a = new int[5];
            a[0] = 3;
            a[1] = 8;
            a[2] = 9;
            a[3] = 7;
            a[4] = 6;
            int cRotacion=1;
            int[] Rotado = sol.solution(a,cRotacion);
            
            for(int indice1 = 0; indice1 <  Rotado.Length; indice1++){
                Console.WriteLine($"Mis números son : {Rotado[indice1]} ");
            }
        }
    }
}
