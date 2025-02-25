using System;

namespace Lecture12
{
    class Program
    {
        static void Main(string[] args) 
        {
            Person p = new Person();
            p.Name = "Haider";   // here we are setting the value
            Console.WriteLine(p.Name);    // here we are getting the value

            p.Age = 20;
            Console.WriteLine(p.Age);

            p.Country = "Pakistan";
            Console.WriteLine(p.Country);

            Console.WriteLine(p.MyName);

            p[0] = "Umer";
            Console.WriteLine(p[0]);

            p[1] = "Hamza";
            Console.WriteLine(p[1]);
            Console.WriteLine(p[0]);


        }
    }
}