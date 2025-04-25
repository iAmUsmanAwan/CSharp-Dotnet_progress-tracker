using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10
{
    //class TextAndNumber
    //{
    //    public string Text;
    //    public int Number;
    
    //}

    class Person
    {
        public string Name;
        public int Age;
        public string Country;

        public void PrintPersonDetails()
        {
            Console.WriteLine($"Person name is: {this.Name} " + $" and age is: {this.Age}" );
        }

        public string GetPersonName()
        {
            return $"My name is {this.Name}" ; 
        }

        //public TextAndNumber GetPersonNameAndAge()
        //{
        //    return new TextAndNumber { Text=this.Name, Number=this.Age };
        //}

        //public (string, int) GetPersonDetails()    // here we have fetched both the data without creating new class 
        //{
        //    return(this.Name, this.Age);
        //}

        public (string MyName, int MyAge, string MyCountry) GetPersonDetails()     
        {
            return (this.Name, this.Age, this.Country);
        }

    }
}
