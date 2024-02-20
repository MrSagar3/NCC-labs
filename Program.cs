using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drive = "C:";
            string folderPath = Path.Combine(drive, "NCC");
            string filePath = Path.Combine(folderPath, "mytest.txt");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder NCC created successfully");
            }

            File.WriteAllText(filePath, "Net Centric Computing");
            Console.WriteLine(" File 'mytest.txt' created or updated");

            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("File content:\n{0}", fileContent);
            Console.ReadKey();
        }
    }
}
