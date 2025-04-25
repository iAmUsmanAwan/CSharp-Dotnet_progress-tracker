using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;    // when working on filesystem
using static System.Console;


namespace Lecture14
{
    internal class DriveManager
    {
        internal static void GetDriveInformation()
        {
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                if (drive.IsReady) 
                {
                    WriteLine(drive.Name + " : " + 
                    drive.DriveType + " : " +  // Fixed
                    drive.TotalSize + " : " +  // size in bytes
                    drive.DriveFormat + " : " +  // NTFS
                    drive.AvailableFreeSpace );   // free space in bytes
                }
                else
                {
                    WriteLine(drive.Name + " : " + 
                        drive.DriveType );
                }
            }
        }
    }
}
