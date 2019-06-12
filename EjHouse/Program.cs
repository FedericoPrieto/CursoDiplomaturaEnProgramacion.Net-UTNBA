using System;

namespace EjHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment depto = new SmallApartment();
            Person person = new Person("Pepe");
            person.MyHouse =depto;
            person.ShowData();

//            Door door = new Door("cafe");
//            depto.MyDoor = door;
            
        }
    }
}
