using System;

namespace Zivotinje_nasledjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Zivotinja konj = new Zivotinja("Radimir", "konj", 88, 420);

            konj.podaci();
            
            Ptica vrabac = new Ptica("Misa", "Vrabac", 520, 15, 2, 0);
            
            vrabac.Ispis();
            Console.WriteLine("Ptica leti: " + vrabac.Leti());
        }
    }
}