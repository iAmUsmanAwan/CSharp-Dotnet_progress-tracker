using System;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);   // This will print the number of arguments passed to the program i.e. after "dotnet run" in the terminal
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[2]);

            // int numberOfApples = 12;
            // decimal pricePerApple = 0.35M;
    //! Interpolated string:
            // Console.WriteLine($"Number of apples: {numberOfApples} costs: {numberOfApples * pricePerApple:C}");  // here :C is used to format the output as currency

            // Console.WriteLine(
            //     format: "{0} apples cost {1:C}",
            //     arg0: numberOfApples,
            //     arg1: numberOfApples * pricePerApple
            // );

            // string formattedString = string.Format(
            //     format: "These {0} apples cost {1:C}",
            //     arg0: numberOfApples,
            //     arg1: numberOfApples * pricePerApple
            // );
            // Console.WriteLine(formattedString);

// TODO: Readkey
            // Console.WriteLine("Press any key combination: ");
            // ConsoleKeyInfo key = Console.ReadKey();
            // Console.WriteLine();  // This line is to clear the Console.ReadLine() leftover buffer
            // // Console.WriteLine($"You pressed: {key.Key}");
            // Console.WriteLine(
            //     format: "Key: {0}, Char: {1}, Modifiers: {2}",
            //     arg0: key.Key,
            //     arg1: key.KeyChar,
            //     arg2: key.Modifiers
            // );

        
        }
    }
}