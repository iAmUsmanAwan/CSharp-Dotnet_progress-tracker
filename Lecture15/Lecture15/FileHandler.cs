using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;


namespace Lecture15
{
    internal class FileHandler
    {
        internal static void WriteToFile()
        {
            FileStream fout = null;
            try
            {
                fout = new FileStream("test.txt", FileMode.Create, FileAccess.Write);   // here we have created and granted access of the file 

                for (char c = 'A'; c <= 'Z'; c++)
                {
                    fout.WriteByte((byte)c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fout.Close();    // to deallocate resources
            }

        }


        internal static void ReadToFile()
        {
            FileStream fin = null;
            try
            {
                fin = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
                int i = fin.ReadByte();
                Console.WriteLine(i);
                Console.WriteLine((char)i);


            }
            catch (Exception ex) 
            {
                
            }
            finally
            {
                fin.Close();
            }

        }

        internal static void WriteFileUsingStreamWriter()
        {
            FileStream fout = null;
            fout = new FileStream("myFile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fout);
            string str = "this is my string which I stored on file";
            sw.Write(str);

            sw.Close();
            fout.Close();

        }

        internal static void ReadFileUsingStreamReader()
        {
            FileStream fout = null;
            fout = new FileStream("myFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fout);
            //string data = sr.ReadToEnd();   // we can read whole like this or from the while loop implimented below
            //string data = sr.ReadLine();  // to only read the first line

            string line = String.Empty;
            while ((line = sr.ReadLine()) != null) 
            {
                Console.WriteLine(line);
            }
            
            //Console.WriteLine(data);

            sr.Close();
            fout.Close();

        }


    }
}