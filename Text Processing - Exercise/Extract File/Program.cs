using System;
using System.Linq;

namespace Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string filePaths = file.Substring(file.LastIndexOf('\\') + 1);
            int dotPosition = filePaths.LastIndexOf('.');
            string fileName=filePaths.Substring(0, dotPosition);
            string fileExtension=filePaths.Substring(dotPosition + 1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
