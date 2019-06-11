using System; 

namespace SimulacroExamen1
{
    public class SolucionE2
    {
        public string ResultadoE2 (int[,] a)
        {
            string sDevolucion = "";
            int iUbicacionN = 0;
            int iUbicacionM = 0;
            int iMayorNumero = 0; 
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (iMayorNumero < a[i, j])   
                        {
                            iMayorNumero = a[i, j]; 
                            iUbicacionN = i;
                            iUbicacionM = j;
                        }
                    }
            }
            sDevolucion = "El mayor número es: " + Convert.ToString(iMayorNumero) + " ubicado en la fila: "; 
            sDevolucion = sDevolucion + Convert.ToString(iUbicacionN) + " y columna; " + Convert.ToString(iUbicacionM);
            return sDevolucion;  
        }
    }
}