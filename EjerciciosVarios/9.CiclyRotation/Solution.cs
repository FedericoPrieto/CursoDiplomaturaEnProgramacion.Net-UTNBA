using System;

namespace EjerciciosVarios._9.CiclyRotation
{
    public class Solution
    {
        public int[] solution(int[] a, int cantRot){
            int indiceNuevo = 0 ;
            int[] b = new int[5];

           for(int indice1 = 0; indice1 <  a.Length; indice1++){
               indiceNuevo = indice1 + cantRot;
               if (indiceNuevo > a.Length - 1){
                   indiceNuevo = indiceNuevo - a.Length ;  
               }               
               b[indice1] = a[indiceNuevo]; 
            }
            return b; 

        }      
    }
}
