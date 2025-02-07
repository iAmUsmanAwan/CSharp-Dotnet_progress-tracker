using System;

namespace Lecture6
{
    class Program
    {
        static void Main(string[] args)
        {

            object o = 78; //? object to be checked

            int k;
            if (o.GetType() == typeof(int))
            {
                k = (int)o;
                Console.WriteLine($"int {k}");
            }
            else if (o.GetType() == typeof(float))
            {
                float f = (float)o;
                Console.WriteLine($"float {f}");
            }

            /** Same code below but improved readibility and simplicity **/

    // TODO: is Operator: 
    //? It is used to check the type of an object at runtime. It returns true if the object is of the specified type, otherwise false.

            if(o is int)
            {
                k = (int)o;   // Typecasting
                Console.WriteLine($"int is {k}");
            }
            else if(o is float)
            {
                float f = (float)o;   // Typecasting
                Console.WriteLine($"float is {f}");
            }

            /** Same code below but improved readibility and simplicity **/

            if (o is int x)
            {
                Console.WriteLine($"{x} is int");
            }
            else if (o is float y)
            {
                Console.WriteLine($"{y} is float");
            }

    // TODO: Iteration statements:
    //? They are used to repeat a block of code a certain number of times. (while , do-while, for, foreach)

            // while loop
            int xk= 0;
            while (xk < 10)
            {
                Console.WriteLine($"while xk: {xk}");
                xk++;
            }

            // do-while loop
            string password = string.Empty;
            do
            {
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
            } while (password != "1234");  
            Console.WriteLine("Correct password");

            // for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"for i: {i}");
            }
            
            // foreach loop
            string[] names = { "Ali", "Ahmed", "Sara" };
            foreach (string name in names)
            {
                Console.WriteLine($"foreach name: {name}");
            }

    // TODO: Switch statements:
    //? It is used to select one of many code blocks to be executed based on different conditions.

            var number = (new Random()).Next(1, 5);
            Console.WriteLine($"Random number: {number}");
            switch (number)
            {
                case 1:   //? the case value must be a literal value
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    Console.WriteLine("Three or Four");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }



        }
    }
}