using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\yxakr\Desktop\California";
            string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in allfiles)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
