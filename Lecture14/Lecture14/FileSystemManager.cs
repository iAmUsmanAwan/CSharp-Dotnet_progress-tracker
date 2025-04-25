using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;    // when working on filesystem
using static System.Console;

namespace Lecture14
{
    internal class FileSystemManager
    {
        static internal void GetFileSystemInfo()
        {
            // path seperaator is different for different operating systems, for windows back slash is used and for linus forward slash is used
            WriteLine("{0} {1}", "Path.PathSeparator", Path.PathSeparator);    // Path.PathSeparator ;
            WriteLine("{0} {1}", "Path.DirectorySeparatorChar", Path.DirectorySeparatorChar);   // DirectorySeparatorChar \
            WriteLine("{0} {1}", "GetTempPath", Path.GetTempPath());   // C:\Users\DELL\AppData\Local\Temp\
            
            WriteLine("{0} {1}", "Directory.GetCurrentDirectory", Directory.GetCurrentDirectory());   // E:\MY_STUFF\web_practice\FullStackWebDev\Dotnet\Lecture14\Lecture14
            WriteLine("{0} {1}", "Environment.CurrentDirectory", Environment.CurrentDirectory);     // E:\MY_STUFF\web_practice\FullStackWebDev\Dotnet\Lecture14\Lecture14
            WriteLine("{0} {1}", "Environment.SystemDirectory", Environment.SystemDirectory);      // C:\WINDOWS\system32
            WriteLine("{0} {1}", "Environment.OSVersion", Environment.OSVersion);     // Microsoft Windows NT 10.0.19045.0
            WriteLine("{0} {1}", "Environment.ProcessorCount", Environment.ProcessorCount);    // 4






        }

    }
}
