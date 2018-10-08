using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "This is a message! :P";
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\Rahul Jain\\sample.txt",true);
            streamWriter.WriteLine(msg);
            streamWriter.Close();
            StreamReader reader = new StreamReader("C:\\Users\\Rahul Jain\\sample.txt");
            Console.WriteLine(reader.ReadToEnd()); 
        }
    }
}
