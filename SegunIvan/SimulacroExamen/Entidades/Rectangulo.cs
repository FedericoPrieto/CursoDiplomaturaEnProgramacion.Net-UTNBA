using System;

namespace SegunIvan.SimulacroExamen.Entidades
{
    public class Rectangulo : Figura
    {
        public Rectangulo(decimal longitudBase, decimal longitudAltura)
        {
            this.Nombre = "Rectangulo";
            /* this.Lados = new Lado[2]{
                longitudBase,
                longitudAltura
            };*/

            this.Lados = new Lado[2];
            this.Lados[0] = new Lado {LongitudCms = longitudBase};
            this.Lados[1] = new Lado {LongitudCms = longitudAltura};

        }

        public override decimal Area(){
            decimal area = 1M;

            for (int i = 0; i < this.Lados.Length; i++)
            {
                area = area * Convert.ToDecimal(this.Lados[i]);
            }

            return area;
        }

        public override decimal Perimetro(){
            decimal perimetro = 0M;

            for (int i = 0; i < this.Lados.Length; i++)
            {
                perimetro = perimetro + Convert.ToDecimal(this.Lados[i]);
            }

            return perimetro * 2M;
        }
    }
}