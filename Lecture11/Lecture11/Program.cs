using System;

namespace Lecture11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Ali", Age = 23, Country = "Pakistan" };

            p.SayHello("Hamza", 55);

            p.MyMethod();   // here default values will be shown

            p.MyMethod("Abbass");
            p.MyMethod("Abbass", 34);
            p.MyMethod("Abbass", 54, 7.8);

            Console.WriteLine(p.TotalMarks(1));
            Console.WriteLine(p.TotalMarks(1,2));
            Console.WriteLine(p.TotalMarks(1,2,3));
            Console.WriteLine(p.TotalMarks(1,2,3,4));
            Console.WriteLine(p.TotalMarks(1,2,3,4,5));
            Console.WriteLine(p.TotalMarks(1,2,3,4,5,6));

            int a = 10;
            int b = 20;
            //int c = 30;  // this value will not be used if we use out in the method parameter. but then we have to mention "int" after "out" in the arguments

            //Console.WriteLine($"Before Passing a = {a}, b = {b} and c = {c}");

            Console.WriteLine($"Before Passing a = {a}, b = {b}");

            p.PassingParameters(a, ref b, out int c);   // here the value of b will be referenced to 20 and as defined in the method it will be incremented by 1, and becomes 21. But the value of c will be outputed from the method

            Console.WriteLine($"After Passing a = {a}, b = {b} and c = {c}");


        }
    }
}