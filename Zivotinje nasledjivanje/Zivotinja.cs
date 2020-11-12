using System;

namespace Zivotinje_nasledjivanje
{
    public class Zivotinja
    {
        private string ime;
        private string rasa;
        private int starost;
        private int tezina;

        public string Ime
        {
            get => ime;
            set => ime = value;
        }

        public string Rasa
        {
            get => rasa;
            set => rasa = value;
        }

        public int Starost
        {
            get => starost;
            set => starost = value;
        }

        public int Tezina
        {
            get => tezina;
            set => tezina = value;
        }

        public Zivotinja(string i, string r, int s, int t)
        {
            ime = i;
            rasa = r;
            starost = s;
            tezina = t;
        }

        public void podaci()
        {
            Console.WriteLine("Ime: " + ime + "\nRasa: " + rasa + "\nStarost: " + starost + "\nTezina: " + tezina);
        }
    }
}