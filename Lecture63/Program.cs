using System;
using System.Linq;

namespace Lecture63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Mustafa", "Ahmad", "Haider", "Ali", "Hassan", "Hussain", "Abbass", "Akbar" };

            var query = names.Where(NameLongerThanFour);   // Defining a linq query using a method group

            var query2 = names.Where(NameLongerThanFour).ToList();   // if we want to execute the query immediately, we can use ToList() method

            foreach (var name in query)
            {
                Console.WriteLine(name);   // Using the linq query
            }  

            static bool NameLongerThanFour(string name)
            {
                return name.Length > 4;
            } 

        }
    }
}
