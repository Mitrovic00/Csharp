namespace Test
{
    public class Devizni : TekuciRacun
    {
        public override void isplata(decimal i)
        {
            decimal provizija = 0.06m;
            base.isplata(i);
            stanje -= i * provizija;
        }

        public override string ToString()
        {
            return ("DEVIZNI= "+stanje+" eura");
        }
    }
}