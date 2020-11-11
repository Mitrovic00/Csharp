using System;

namespace Koordinata_svojstva
{
    class Program
    {
        static void Main(string[] args)
        {
            Koordinata k1 = new Koordinata();
            k1.ispis();
            
            k1.promeniY(5);
            k1.X = -500;

            k1.ispis();

            k1.reset();
            k1.ispis();

            k1._z = 500;
            k1.ispis();
        }
    }
}