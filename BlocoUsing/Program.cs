using System;
using System.IO;
using System.Xml;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\lucas\Documents\Downloads";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
