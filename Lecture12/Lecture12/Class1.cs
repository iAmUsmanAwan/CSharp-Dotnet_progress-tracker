using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12
{
    partial class Person    // same class which is defined in different files 
    {
        private string name;
        public string Country { get; set; }   // A private data member is automatically created against it

        public string MyName => this.name;   // $"This is my name: {name}";

        public string Name
        {
            get
            {
                return name;
            }
            set    // if we remove this setter method then it will be readOnly value 
            {
                name = value;
            }
        }


        private string favouritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return FavoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not primary color, " + "Choose from: red, green, blue. ");

                }
            }
        }


        private string[] strData = new string[10];
        
        public string this[int index]   // Indexer
        {
            get => strData[index];
            set => strData[index] = value;
        }


    }
}
