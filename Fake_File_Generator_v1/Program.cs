using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Fake_File_Generator_v1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Fake File Generator v1 by +AGC007+";
            Console.WriteLine("=============================================");
            Console.WriteLine("============ Fake File Generator ============");
            Console.WriteLine("==============  Version: 1.0  ===============");
            Console.WriteLine("============ Developer: +AGC007+ ============");
            Console.WriteLine("=============================================");
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\r\nEnter output path: ");
                string path = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\r\nEnter size of file (MB): ", ConsoleColor.Cyan, ConsoleColor.Black);
                long num = long.Parse(Console.ReadLine()) * 0x100000;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\r\nEnter creation date:--11/11/10--:", ConsoleColor.Cyan, ConsoleColor.Black);
                DateTime creationTime = DateTime.Parse(Console.ReadLine());
                FileStream stream1 = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
                stream1.SetLength(num);
                stream1.Close();
                File.SetCreationTime(path, creationTime);
                File.SetLastWriteTime(path, creationTime);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\nFile successfully generated, file path: " + path, ConsoleColor.Green, ConsoleColor.Black);
            }
            catch (Exception exception)
            {
                Console.WriteLine("\r\nAn error occurred: " + exception.Message, ConsoleColor.Red, ConsoleColor.Black);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\r\nPress any key to close . . . ");
            Console.ReadKey(true);
        }



    }
}
