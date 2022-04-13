using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ListSub
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("C://essay1.txt");
            //file.Attributes = FileAttributes.Normal;
            Console.WriteLine("file name: " + file.Name);
            Console.WriteLine("file extension: " + file.Extension);
            Console.WriteLine("file size: " + file.Length);
            Console.WriteLine("file creation time: " + file.CreationTime);
            Console.WriteLine("file last access time: " + file.LastAccessTime);
            Console.ReadKey();

        }
    }
}
