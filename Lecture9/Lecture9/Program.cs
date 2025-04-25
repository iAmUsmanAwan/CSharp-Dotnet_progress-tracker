using System;
using System.Xml.Linq;

namespace Lecture9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person("Ali", 13);
            Console.WriteLine(personObj.Name);
            Console.WriteLine(personObj.Age);
            Console.WriteLine(Person.Country);   // Static data is shared data, it will be accessed by the class not the object
            Console.WriteLine(Person.HomePlanet);
            Console.WriteLine(personObj.HomePlanet2);
            //personObj.HomePlanet2 = "Sun";   // readonly fields cannot be reassigned


            Person P2 = new Person(age: 14, name: "Ibrahim");   // here when we are using named arguments, then position does not matter
            Console.WriteLine(P2.Name);
            Console.WriteLine(P2.Age);
            Console.WriteLine(Person.Country);

            personObj.Name = "Mustafa";
            Console.WriteLine(personObj.Name);

            Person.Country = "China";   // This will be changed for the whole class not just one object

            Person P3 = new Person() { Age= 23, Name= "Musa"};
            Console.WriteLine(P3.Name);
            Console.WriteLine(P3.Age);
            Console.WriteLine(Person.Country);

            Console.WriteLine(P2.Name);
            Console.WriteLine(P2.Age);
            Console.WriteLine(Person.Country);   // now the country is changed



        }
    }
}
