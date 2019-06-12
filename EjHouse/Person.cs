using System; 

namespace EjHouse
{
    public class Person
    {
        string Name{get;}

        House MyHouse{get; set;}

        public Person(string name)
        {
            Name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"Soy una personasa llamada{name}");

            MyHouse.ShowData();

            MyHouse.MyDoor.ShowData();
        }


    }
}