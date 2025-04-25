using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9
{
    public class Person  : System.Object  // this is inherited from 'system.object' always even if we dont write it
    {
        public string Name;
        public int Age;
        public static string Country = "Pakistan";
        public const string HomePlanet = "Earth";   // const cannot be changed, unlike the static
        public readonly string HomePlanet2;

        public void Calculate(int Z)
        {
            const int X = 10, Y = 20;
            const int W = X + Y;
            //const int R = X + Z;  // this cannot be assigned because it is assigned during the runtime, this will be catered by readonly 
        }

        public Person() {
            Name = default;
            Age = default;
            HomePlanet2 = "Mooon";
        }

        public Person(string name, int age) { 
            this.Name = name;
            this.Age = age;
            HomePlanet2 = "Mooon";

        }

    }
}
