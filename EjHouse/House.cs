using System;

namespace EjHouse
{
    public class House
    {
        double Area{get; set;}
        public Door MyDoor{get;}

        public House(double area, string colorPuerta)
        {
            Area = area;
            MyDoor = new Door(colorPuerta);
        }

        public void ShowData()
        {
            Console.WriteLine($"Soy una Casa mi área es de {Area} m2");
        }

    }
}