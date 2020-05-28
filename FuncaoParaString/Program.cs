using System;

namespace FuncaoParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC DEFG    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5 );
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original:  -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower -" + s2 + "-");
            Console.WriteLine("Trim -" + s3 + "-");

            Console.WriteLine("IndexOf: -" + n1);
            Console.WriteLine("LastIndexOf: -" + n2);
            Console.WriteLine("Substring: " + s5);
            Console.WriteLine("Replace: " + s6);
            Console.WriteLine("Replace: " + s7);
            Console.WriteLine("IsNullOrEmpety: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}
