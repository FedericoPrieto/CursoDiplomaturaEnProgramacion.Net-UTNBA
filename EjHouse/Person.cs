using System; 

namespace EjHouse
{
    public class Person
    {
        string Name{get; set;}

        public House MyHouse{get; set;}

        public Person(string name)
        {
            Name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"Soy una personasa llamada{Name}");

            MyHouse.ShowData();

            MyHouse.MyDoor.ShowData();
        }


    }
}