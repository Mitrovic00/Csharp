using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinarski din = new Dinarski();
            Console.WriteLine(din);
            Console.WriteLine(din.Stanje);
            
            Devizni dev = new Devizni();
            Console.WriteLine(dev);
            Console.WriteLine(dev.Stanje);
            
            din.uplata(50000m);
            Console.WriteLine(din);

            dev.uplata(1000m);
            Console.WriteLine(dev);
            
            din.isplata(10000m);
            dev.isplata(200m);
            
            Console.WriteLine(din);
            Console.WriteLine(dev);
            
            Console.ReadLine();
        }
    }
}