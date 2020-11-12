using System;

namespace Nasledjivanje
{
    public class Student:Osoba
    {
        private int brojIspita;

        public Student(string i, string p, int bi) : base(i, p)
        {
            brojIspita = bi;
        }

        public void podaciStudenta()
        {
            Console.WriteLine("Ime i prezime: " + ime + " " + prezime + "\nBroj ispita: " + brojIspita);
        }
    }
}