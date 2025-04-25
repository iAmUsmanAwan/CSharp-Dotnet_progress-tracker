using System;

using System.Text.Json;
using System.Text.Json.Serialization;

using System.IO;

namespace Lecture16
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //FileManager.ManageFiles();

            Person p = new Person
            {
                Name = "Ali",
                Age = 25,
                Address = new Address
                {
                    City = "Lahore",
                    Country = "Pakisan",
                    ZIP = 5400
                }
            };

            string jsonOutput = JsonSerializer.Serialize(p);    // Json data returned in String form
            Console.WriteLine(jsonOutput);

            File.WriteAllText("myFile.txt", jsonOutput);    // saving the information in the myFile.txt in json format

            string jsonString = File.ReadAllText("myFile.txt");

            Person p2 = JsonSerializer.Deserialize<Person>(jsonString);   // Deserializing
            Console.WriteLine(p2.Name);

        }
    }
}