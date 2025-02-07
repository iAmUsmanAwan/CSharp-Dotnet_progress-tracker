using System;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {

// TODO: Object type:
//* This is a special type in C# that can store any type of data.

            object objectNumber = 10;
            object objectString = "This is my object String";
            object objectFloatingNumber = 23.45;
            
            string myString = "This is my string type String";
            int lenghtOfString = myString.Length;
            int lenghtofObjectString = objectString.ToString().Length;

// TODO: Dynamic type:
//? This is a type that can store any type of data and can change its type at runtime. it is not checked at compile time.

            dynamic myDynamicString = "This is the dynamic string";
            int lenghtOfDynamicString = myDynamicString.Length;

// TODO: Var type:
//? This is a type that can store any type of data and the compiler will automatically detect the type of data. we should use it when we are sure about the type of data.

            var x = 10;
            var y = "This is the var string";
            var z = 23.45;

            int population = 66_000_000; // 66 million in the UK

            Console.WriteLine($"The UK population is {population}");

// ? Default values:
            Console.WriteLine(default(int)); // 0
            Console.WriteLine(default(bool)); // False
            Console.WriteLine(default(string)); // Empty string
            Console.WriteLine(default(decimal)); // 0

// TODO: Arrays:

            string[] names;
            names = new string[4];

            names[0] = "Ahmed";
            names[1] = "Ali";
            names[2] = "Hamza";
            names[3] = "Khalid";
            Console.WriteLine(names[1]);

// TODO: User input:
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            // int age = Console.ReadLine();
            Console.Write("Your name is " + name +  "? \n");

        }
    }
}