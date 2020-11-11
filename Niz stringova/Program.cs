using System;

namespace Niz_stringova
{
    class Program
    {
        static void NizStringova(params string[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(niz[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            NizStringova("UOPA", "SYKA");
            string[] a = new string[] {"Aleksa", "Matija", "Mitar"};
            
            NizStringova(a);
        }
    }
}