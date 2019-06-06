using System;

namespace EjerciciosVarios._8.OddOcurrencesInArray
{
    public class Solution
    {
        public string solution(int[]a){
        int[,] aTemp = new int[7,7]; 
        int iTemp = 0;
        int iValorAnt = 0; 
        int jAnt = 0; 
        Console.WriteLine($"Len i: {aTemp.Length}");

        for (int i = 0; i < aTemp.Length - 1; i++)
        {
            Console.WriteLine($"Variable i: {i}");
            aTemp[i,0] = a[i]; 
            aTemp[i,1] = 0;
        }

        for (int i = 0; i < aTemp.Length - 1; i++)
        {
            for (int j = i; j < aTemp.Length - 1; j++)
            {
                if(j == 0 ) 
                {
                    iValorAnt = a[j]; 
                    jAnt = j; 
                    j++;  
                };
                iTemp = a[j]; 

                if (iValorAnt == iTemp)
                {
                    aTemp[jAnt,1] = 1;
                    aTemp[j,1] = 1; 
                    break; 
                }
            }
        }

        string sNum = ""; int sValNum = 0;

        for (int i = 0; i < aTemp.Length - 1; i++)
        {
            if (aTemp[i,1]== 1) 
            {
                sValNum = aTemp[i,1]; 
                if (sNum == "") 
                {
                    sNum = Convert.ToString(sValNum);  
                }
                else 
                {
                    sNum = ", " + sValNum.ToString();  
                }
            }
            aTemp[i,0] = a[i]; 
            aTemp[i,1] = 0;
        }

        return sNum;
        }      
    }
}
