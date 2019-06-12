using System;

namespace EjHouse
{
    public class Door
    {
        public string Color {get; set;}        

        public Door(string color)
        {
            Color = color;
        }
        public void ShowData()
        {
            Console.WriteLine($"Soy una Puerta, mi color es {Color}");
        }

    }
}