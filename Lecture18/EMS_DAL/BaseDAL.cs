using System;
using System.Globalization;
using System.IO;

namespace EMS_DAL
{
    public class BaseDAL     // this will be called from EMS_DAL
    {
        public void Save(string text, string fileName)    // recieving input as text not object
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

            // Open the StreamWriter and write to the file
            using (StreamWriter sw = new StreamWriter(filePath, append: true))
            {
                sw.WriteLine(text);  // Write the text to the file
            }
        }

        internal List<string> Read(string fileName)    // here return type is list of strings 
        {
            List<string> list = new List<string>();   // created an empty list

            string filePath = Path.Combine(Environment.CurrentDirectory , fileName);

            StreamReader sr = new StreamReader(filePath);  // open file
            
            string line = String.Empty;    // defined an empty string
            
            while((line = sr.ReadLine()) != null)
            {
                list.Add(line);
            }
            return list;

        }

    }
}
