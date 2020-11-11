using System;

namespace TV
{
    public class Televizor
    {
        public int _jacinaTona = 0;
        public bool ukljucen = false;

        public int JacinaTona
        {
            get => _jacinaTona;
            set => _jacinaTona = value;
        }

        public void pojacanTon()
        {
            _jacinaTona += 1;
        }

        public void smanjiTon()
        {
            _jacinaTona -= 1;
        }

        public void Ukljuci()
        {
            ukljucen = true;
        }

        public void Iskljuci()
        {
            ukljucen = false;
        }

        public void DaLiJeUkljucen()
        {
            if (ukljucen = true)
            {
                Console.WriteLine("Televizor je ukljucen");
            }
            else
            {
                Console.WriteLine("Televizor je iskljucen");
            }
            
        }

        public void VratiJacinuTona()
        {
            Console.WriteLine("Trenutna jacina tona je " + _jacinaTona);
        }

        public void ispisi()
        {
            Console.WriteLine("Televizor je trenutno na jacini " + _jacinaTona + ". Da li je ukljucen? " + ukljucen);
        }
        
    }
}
