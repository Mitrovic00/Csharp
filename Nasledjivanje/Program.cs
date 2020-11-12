using System;
using System.Security.Cryptography.X509Certificates;

namespace Nasledjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba( "Marko", "Mitrovic");
            o1.podaciOsobe();
            
            Student s1 = new Student("Matija", "Jovanovic", 11419);
            s1.podaciOsobe();
            s1.podaciStudenta();
        }
    }
}