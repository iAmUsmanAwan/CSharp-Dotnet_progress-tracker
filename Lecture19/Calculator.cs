using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lecture19
{
    internal class Calculator
    {
        static internal int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Add method result: {result}");
            return result;
        }

        static internal int Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtract method result: {result}");
            return result;
        }

        static internal int Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiply method result: {result}");
            return result;
        }

    }
}
