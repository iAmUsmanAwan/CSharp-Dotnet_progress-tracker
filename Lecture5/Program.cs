using System;

namespace Lecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Formatting output using positional arguments
            //? {index[,alignment][:formatString]}
            // for left alogn we use negative value of alignment, for right alignment we use positive value of alignment

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            Console.WriteLine(
                format: "{0, -9} {1,6}",
                arg0: "Name",
                arg1: "Count"
            );

            Console.WriteLine(
                format: "{0, -9} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount
            );

            Console.WriteLine(
                format: "{0, -9} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );


        // TODO: Operators:
            /*
            * 1. Unary Operators (Increment, Decrement, typeof, sizeof)
            * 2. Binary Operators (+, -, *, /, %)
            * 3. Assignment Operators (=, +=, -=, *=, /=, %=)
            * 4. Logical Operators (AND &&, OR |, XOR ^, NOT !)
            */

        // TODO: If else:

            if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("One argument");
            }
            else
            {
                Console.WriteLine($"{args.Length} arguments");
            }

        }
    }
}