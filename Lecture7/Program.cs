using System;

namespace Lecture7
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Typecasting (Implicit and Explicit)

            //* Implicit Typecasting {Smaller data type to larger data type} , no data loss
            int i = 100;
            double f = i; // Implicit typecasting
            Console.WriteLine($"Implicit typecasting: {f}");

            //* Explicit Typecasting {Larger data type to smaller data type} , data loss
            double d = 200.53;
            int j = (int)d; // Explicit typecasting , here we are losing the decimal part
            Console.WriteLine($"Explicit typecasting: {j}");

            //* Converting types using System.Convert method.
            double e = 200.53;
            int k = System.Convert.ToInt32(e); // Converting double to int
            Console.WriteLine($"e is {e} &Converting using Convert method: {k}");

            //* Rounding Rule {Bankers Rounding}
            double[] doubles = new [] 
                {
                    9.51, 10.51, 9.49, 10.49, 9.5, 10.5
                };
                foreach (double n in doubles)
                {
                    Console.WriteLine($"Rounding {n} by Bankers Rounding : {Math.Round(n)}");
                }

            //* Traditional Rounding Rule {AwayFromZero}
            foreach (double n in doubles)
            {
                Console.WriteLine(Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
            }

            //* Converting into String
            int number = 12;
            Console.WriteLine($"Converting int to string: {number.ToString()}");
            bool boolean = true;
            Console.WriteLine($"Converting bool to string: {boolean.ToString()}");
            DateTime now = DateTime.Now;
            Console.WriteLine($"Converting DateTime to string: {now.ToString()}");
            object obj = new object();
            Console.WriteLine($"Converting object to string: {obj.ToString()}");

            //* Converting from string to other types
            int age = int.Parse("25");
            DateTime dob = DateTime.Parse("1999-09-13");
            Console.WriteLine($"Age: {age}, DOB: {dob}");   // Age: 25, DOB: 9/13/1999 12:00:00 AM
            Console.WriteLine($"Age: {age}, DOB: {dob:D}");   // Age: 25, DOB: Monday, September 13, 1999

            //* TryParse method
            Console.WriteLine("How many eggs are there?");
            int count;
            string input = Console.ReadLine();  // Read the input from the user, it will be a string returned
            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input.");
            }

            //* Try int Catch method
            Console.WriteLine("Before Parsing");
            Console.WriteLine("What is your age?");
            input = Console.ReadLine();
            try
            {
                int age1 = int.Parse(input);
                Console.WriteLine($"Your age is {age1}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Your Format is incorrect, Please enter age in numbers only.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Your Format is correct, Please enter age from 0 to 99.");
            }
            catch (Exception ex)   // Catch all other exceptions
            {
                Console.WriteLine($"{ex.GetType()} says: {ex.Message}");
                // Console.WriteLine("We are in Catch block");
            }

            Console.WriteLine($"int range is from {int.MinValue} to {int.MaxValue}");    //? int range is from -2147483648 to 2147483647
            int x = int.MaxValue - 1;
            checked
            {
                Console.WriteLine($"Initial value: {x}");
                x++;    //? here we have reached to the maximum value of int
                Console.WriteLine($"After increment: {x}");   // After increment: 2147483647
                x++;    // Crossing the maximum value of int
                Console.WriteLine($"After increment: {x}");   // After increment: -2147483648  without check block
                x++;
                Console.WriteLine($"After increment: {x}");   // After increment: -2147483647 without check block
            }


        }
    }
}