using System;

namespace EjerciciosVarios._9.CiclyRotation
{
    public class Solution
    {
        public int[] solution(int[] a, int k){
            int indiceNuevo = 0 ;
            int[] b = new int[a.Length];

           for(int i = 0; i <  a.Length; i++){
               indiceNuevo = i + k;
               if (indiceNuevo > a.Length - 1){
                   indiceNuevo = indiceNuevo %  a.Length  ;  
               }               
               b[i] = a[indiceNuevo]; 
            }
            return b; 

        }      
    }
}
