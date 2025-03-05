using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using static System.Console;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

namespace Lecture16
{
    internal class FileManager
    {
        internal static void ManageFiles()
        {
            string textFile = Path.Combine(Environment.CurrentDirectory, "streams.txt");

            WriteLine(File.Exists(textFile));
            StreamWriter sw = File.CreateText(textFile);   // file Created
            WriteLine(File.Exists(textFile));

            sw.WriteLine("this is the text.");
            sw.Close();

            // 
            WriteLine($"Folder name : {Path.GetDirectoryName(textFile)}");
            WriteLine($"File name : {Path.GetFileName(textFile)}");
            WriteLine($"File name without extension : {Path.GetFileNameWithoutExtension(textFile)}");
            WriteLine($"File Extension : {Path.GetExtension(textFile)}");

            //
            var info = new FileInfo(textFile);
            WriteLine($"Total Bytes {info.Length}");
            WriteLine($"Last Accessed {info.LastAccessTime}");
            WriteLine($"Is Read Only {info.IsReadOnly}");

            //
            string backupFile = Path.Combine(Environment.CurrentDirectory, "myBaackupFile.bak");
            File.Copy(sourceFileName:textFile, destFileName:backupFile, overwrite:true);

            // to delete a a file
            //File.Delete(textFile);

            //
            StreamReader sr = File.OpenText(backupFile);
            WriteLine(sr.ReadToEnd());
            sr.Close();

            WriteLine(File.ReadAllText(backupFile));    // without using stream reader, same output


        }
    }
}
