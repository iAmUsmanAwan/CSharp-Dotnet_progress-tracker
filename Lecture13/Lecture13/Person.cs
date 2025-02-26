using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} year{GenerateAgeSuffix(Age)} old";
            
            // Defining a local function:
            string GenerateAgeSuffix(int age)
            {
                return age > 1 ? "s" : "";
            }

        }


        public static void Display(String str)
        {
            int ctr = 3;
            DisplayText();

            void DisplayText()
            {
                for (int i = 0; i < ctr; i++)
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}
