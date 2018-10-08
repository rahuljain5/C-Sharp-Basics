using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class DirSimulation
    {
        public static void Main()
        {

            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo("C:\\Users\\Rahul Jain");
            foreach (var directory in directoryInfo.GetDirectories())
            {
                Console.WriteLine(directory.Name);
            }
            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine("Name: "+file.Name);
                Console.WriteLine("Size: " + file.Length);
                Console.WriteLine("-----------------------------------");
            }

            //DriveInfo[] drives = DriveInfo.GetDrives();
            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine("Name: " + drive.Name);
            //    Console.WriteLine("Label: " + drive.VolumeLabel);
            //    Console.WriteLine("Total Size: " + drive.TotalSize);
            //    Console.WriteLine("Free Space: " + drive.TotalFreeSpace);
            //    Console.WriteLine("---------------------------------------------------");

        //}
        }
    }
}
