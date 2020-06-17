using System;
using System.IO;

namespace StreamWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\lucas\Documents\Downloads\file1.txt";
            string targetPath = @"C:\Users\lucas\Documents\Downloads\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
