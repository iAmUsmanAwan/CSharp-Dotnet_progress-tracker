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

            object[] myObjects = { 1, 2.5, "hello", true, null };

    // TODO: Switch statement with pattern matching:
    //? the case value no longer need to be a literal value, it can be a pattern.

            foreach (var obj in myObjects)
            {
                switch (obj)
                {
                    case int i:
                        Console.WriteLine($"int: {i}");
                        break;
                    case double d:
                        Console.WriteLine($"double: {d}");
                        break;
                    case string s:
                        Console.WriteLine($"string: {s}");
                        break;
                    case bool bo:
                        Console.WriteLine($"bool: {bo}");
                        break;
                    case null:
                        Console.WriteLine("null");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }

    // TODO: switch Expression: (C# 8.0)

            var operation = 2;
            var result = operation switch
            {
                1 => "Addition",
                2 => "Subtraction",
                3 => "Multiplication",
                4 => "Division",
                _ => "Invalid operation"
            };
            Console.WriteLine($"Result: {result}");

    /** ----------------------------- **/

            int a= 10, b= 20;
            var option = "+";
            var result1 = option switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                _ => 0
            };
            Console.WriteLine($"Result: {result1}");

    /** ----------------------------- **/

            var value = 51;
            var message = value switch
            {
                < 50 => "Less than 50",
                > 50 => "Greater than 50",
                _ => "Equal to 50"
            };
            Console.WriteLine(message);

    /** ----------------------------- **/

            var value1 = 51;
            var message1 = value1 switch
            {
                _ when value1 % 2 == 0 => "Even",
                _ => "Odd"
            };
            Console.WriteLine(message1);

    /** ----------------------------- **/

            var value2 = 51;
            var message2 = value2 switch
            {
                _ when value2 < 10 => 0,
                _ when value2 > 10 && value < 50 => 1,
                _ => 100,
            };
            Console.WriteLine(message2);

    /** ----------------------------- **/

            object[] myObjects1 = { 1, 2, "hello", 2.35, true, null, 4.5f };
            var j = 10;
            foreach (var obj in myObjects1)
            {
                var message3 = obj switch
                {
                    float f => $"this is float {f}, j+3 = {j + 3}",  //? multiple statements
                    string s => $"this is string {s}",
                    double d => $"this is double {d}",
                    int i => $"this is int {i}",
                    null => "this is null value",
                    _ => "other",
                };
                Console.WriteLine(message3);
            }


        }
    }
}