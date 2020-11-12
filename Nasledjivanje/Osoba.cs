using System;
using System.Buffers;

namespace Nasledjivanje
{
    public class Osoba
    {
        protected string ime;
        protected string prezime;

        public Osoba(string i, string p)
        {
            ime = i;
            prezime = p;
        }

        public void podaciOsobe()
        {
            Console.WriteLine("Ime i prezime: " + ime + " " + prezime);
        }
    }
}