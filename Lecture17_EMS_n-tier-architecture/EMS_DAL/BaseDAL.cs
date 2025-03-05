using System;
using System.IO;

namespace EMS_DAL
{
    public class BaseDAL
    {
        public void Save(string text, string fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

            // Open the StreamWriter and write to the file
            using (StreamWriter sw = new StreamWriter(filePath, append: true))
            {
                sw.WriteLine(text);  // Write the text to the file
            }
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//using EMS_BO;
//using System.IO;

//namespace EMS_DAL
//{
//    public class BaseDAL    // this will be called from EMS_DAL
//    {
//        public void Save(string text, string fileName)   // recieving input as text not object
//        {
//            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
//            StreamWriter sw = new StreamWriter(filePath, append:true);
//            sw.WriteLine();
//            sw.Close();

//        }
//    }
//}
