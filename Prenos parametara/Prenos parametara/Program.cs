using System;

namespace Prenos_parametara
{
    class Program
    {
        static void kvadrat(ref int n)
        {
            n *= n;
        }

        static void koren(ref double n)
        {
            n = Math.Sqrt(n);
        }

        static void uvecan(ref int n)
        {
            n *= 2;
        }

        static void kubni(out double a)
        {
            a = Math.PI;
            a = Math.Pow(a, 3);
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("KVADRAT UNETOG BROJA");
            Console.Write("Unesi neki broj: ");
            int br = int.Parse(Console.ReadLine());
            
            kvadrat(ref br);
            
            Console.WriteLine("Kvadrat unetog broja je: " + br);
            
            Console.WriteLine("\nKOREN REALNOG BROJA");
            Console.WriteLine("Unesite realan broj: ");
            double broj = double.Parse(Console.ReadLine());
            koren(ref broj);
            Console.WriteLine("Koren realnog broja iznosi: " + broj);
            
            Console.WriteLine("\nDVOSTRUKO UVECAN CEO BROJ");
            Console.WriteLine("Unesite ceo broj: ");

            int c = int.Parse(Console.ReadLine());
            
            uvecan(ref c);
            
            Console.WriteLine("Ceo broj pomnozen sa 2 iznosi: " + c);

            double k;
            
            Console.WriteLine("Kubna vrednost broja pi iznosi: ");
            kubni(out k);
            Console.WriteLine(k);

        }
    }
}