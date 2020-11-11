using System;

namespace Prenos_parametara_string
{
    class Program
    {
        static void str(out string n[])
        {
            n = "VEZBAMO PRENOS PARANETARA";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Prenos string parametara");
            string s1;
            
            str(out s1);
            Console.WriteLine(s1);
        }
    }
}