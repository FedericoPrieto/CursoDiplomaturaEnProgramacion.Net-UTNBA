using System;

namespace EjHouse
{
    public class House
    {
        double Area{get; set;}

        public Door MyDoor{get; set;}

        public House(double area)
        {
            Area = area;
        }

        void ShowData()
        {
            Console.WriteLine($"Soy una Casa mi área es de {Area} m2");
        }

    }
}