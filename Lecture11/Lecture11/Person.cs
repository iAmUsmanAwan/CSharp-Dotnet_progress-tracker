using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11
{
    class Person
    {
        public string Name;
        public int Age;
        public string Country;

        public void SayHello()
        {
            Console.WriteLine($"People of Wadiya, My name is {this.Name}");
        }

        public void SayHello(string inputName)   // method overloading
        {
            Console.WriteLine($"People of Wadiya, My name is {this.Name} and input name is {inputName}");
        }

        public void SayHello(string inputName, int myValue)   // method overloading
        {
            Console.WriteLine($"People of Wadiya, My name is {this.Name} and input name is {inputName} and input value is {myValue}");
        }

        public void MyMethod(string name = "Talha", int someValue=6, double someOtherValue = 4.4)   // if we define one default parameter then all of them should be defined
        {
            Console.WriteLine($"My name is {name} and int value is {someValue} and double is {someOtherValue}");
        }

        public int TotalMarks(params int[] data)
        {
            int result = 0;
            
            foreach (int num in data)
            {
                result += num; // Adding each number to result
            }
            
            return result;
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            z = 99;
            //y = 10;
            x++;
            y++;
            z++;
        }

    }
}
