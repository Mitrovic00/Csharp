using System;

namespace Koordinata_svojstva
{
    public class Koordinata
    {
        private int _x;
        public int Y { get; private set; }
        public int _z;

        public int X
        {
            get { return _x; }
            set
            {
                if (X > 0)
                {
                    _x = value;
                }
                else
                {
                    _x = 0;
                }
            }
        }

        public void promeniY(int y)
        {
            Y = y;
        }

        public void ispis()
        {
            Console.WriteLine("X=" + _x + " Y=" + Y + " Z=" + _z);
        }

        public void reset()
        {
            X = Y = _z = -5;
        }

    }
}