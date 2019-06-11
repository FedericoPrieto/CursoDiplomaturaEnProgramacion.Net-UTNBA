namespace SimulacroExamen1
{
    public class Solucion
    {
        public decimal ValorDeCompra(decimal cantDolar, decimal valorDolar)
        {
            decimal porcentajeASumar = 1.05M; 
            decimal valorDeCompra = cantDolar * valorDolar * porcentajeASumar; 
            return valorDeCompra;
        }
    }
}