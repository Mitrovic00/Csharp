namespace Test
{
    public class TekuciRacun
    {
        protected decimal stanje;

        public decimal Stanje
        {
            get => stanje;
            private set => stanje = value;
        }

        public void uplata(decimal u)
        {
            stanje += u;
        }

        public virtual void isplata(decimal i)
        {
            stanje -= i;
        }

        public override string ToString()
        {
            return ("RACUN=" + stanje);
        }
    }
}