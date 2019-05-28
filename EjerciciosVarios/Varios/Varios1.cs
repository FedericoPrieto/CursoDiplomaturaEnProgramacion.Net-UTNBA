using System;

namespace EjerciciosVarios.Varios
{
    public class Varios1
    {
      public int ContCeros  (int n )  {
          string valorEnBinario = Convert.ToString(n,2);
          int valorMaximoCeros = 0;
          int contador = 0;

          for (int x = 0; x < valorEnBinario.Length; x++){
            if (valorEnBinario[x]=='0'){
              contador++;
            }
            else{
              if(contador>valorMaximoCeros){
                valorMaximoCeros = contador;
              }
              else
                contador=0;
            }
          }
          return valorMaximoCeros;
      }
    }
}