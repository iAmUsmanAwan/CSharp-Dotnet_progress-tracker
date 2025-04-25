using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;    // when working on filesystem
using static System.Console;

namespace Lecture14
{
    internal class DirectoryManager
    {
        static internal void WorkingWithDirectories()
        {
            var newFolder = Path.Combine(Directory.GetCurrentDirectory(), "MyNewFolder");

            WriteLine(Directory.Exists(newFolder));

            Directory.CreateDirectory(newFolder);   // Created the folder

            WriteLine(Directory.Exists(newFolder));

            Directory.Delete(newFolder, recursive:true);

            WriteLine(Directory.Exists(newFolder));


        }
    }
}
