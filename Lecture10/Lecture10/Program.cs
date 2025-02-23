using System;

namespace Lecture10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Age = 12, Name = "Ali", Country = "Pakistan" }; 
            
            p.PrintPersonDetails();
            Console.WriteLine(p.GetPersonName());

            //Console.WriteLine("The name is " + p.GetPersonNameAndAge().Text + " and age is " + p.GetPersonNameAndAge().Number );

            //(string, int) personData = p.GetPersonDetails();
            //Console.WriteLine(personData.Item1);
            //Console.WriteLine(personData.Item2);

            var personData = p.GetPersonDetails();
            Console.WriteLine(personData.MyName);
            Console.WriteLine(personData.MyAge);
            Console.WriteLine(personData.MyCountry);

            (string n, int a, string c) personData2 = p.GetPersonDetails();
            Console.WriteLine(personData2.n);
            Console.WriteLine(personData2.a);
            Console.WriteLine(personData2.c);

            (string name, int age, string country) = p.GetPersonDetails();
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(country);

        }
    }
}