namespace Test
{
    public class Dinarski : TekuciRacun
    {
        public override void isplata(decimal i)
        {
            decimal provizija = 0.05m;
            base.isplata(i);
            stanje -= i * provizija;
        }

        public override string ToString()
        {
            return ("DINARSKI=" +stanje+" dinara");
        }
    }
}