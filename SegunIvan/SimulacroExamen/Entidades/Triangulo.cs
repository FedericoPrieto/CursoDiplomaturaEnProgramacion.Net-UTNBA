using System;

namespace SegunIvan.SimulacroExamen.Entidades
{
    public class Triangulo:Figura
    {
       public Triangulo(decimal bases, decimal altura)
       {
        this.Nombre = "Triangulo";
        this.Lados = new Lado[2];
        this.Lados[0] = new Lado {LongitudCms = bases};
        this.Lados[1] = new Lado {LongitudCms = altura};

       }
       
       public override decimal Area(){
            decimal area = 1M;

            for (int i = 0; i < this.Lados.Length; i++)
            {
                area = area * Convert.ToDecimal(this.Lados[i]);
            }

            //Suponiendo que cada lado corresponde a base y a altura
            area = area / 2M;

            return area;
        }

        public override decimal Perimetro(){
            decimal perimetro = 0M;

            for (int i = 0; i < this.Lados.Length; i++)
            {
                perimetro = perimetro + Convert.ToDecimal(this.Lados[i]);
            }

            //asumo que el perímetro es igual a base por altura
            return perimetro * 2M;
        }        
    }
}