using System;

namespace FirstProject
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


        }
    }
}