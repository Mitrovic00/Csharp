using System;

namespace Zivotinje_nasledjivanje
{
    public class Ptica:Zivotinja
    {
        private int rasponKrila;
        private int brzina;

        public int RasponKrila
        {
            get => rasponKrila;
            set => rasponKrila = value;
        }

        public int Brzina
        {
            get => brzina;
            set => brzina = value;
        }

        public Ptica(string i, string r, int s, int t, int rasp, int brz) : base(i, r, s, t)
        {
            rasponKrila = rasp;
            brzina = brz;
        }

        public bool Leti()
        {
            if (brzina > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Ispis()
        {
            Console.WriteLine("Ime: " + Ime + "\nRaspon krila: " + rasponKrila + "\nBrzina: " + brzina);
        }
    }
}