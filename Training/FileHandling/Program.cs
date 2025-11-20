using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\poojati\\dotnet_trg\\Training\\text.txt";

            //Writing to a file
                using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is a sample text file.");
            }

                //Reading from file
                using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
                //Appending to a file
                using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Appending a new line to the file.");
            }

                //Reading the updated file
                using (StreamReader reader =new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Updated file content:");
                Console.WriteLine(content);
            }
        }
    }
}
