using System;

namespace EjHouse
{
    public class Door
    {
        string Color {get; set;}        

        public Door(string color)
        {
            Color = color;
        }
        void ShowData()
        {
            Console.WriteLine($"Soy una Puerta, mi color es {color}");
        }

    }
}