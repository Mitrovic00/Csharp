namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            Televizor t1 = new Televizor();
            
            
            t1.pojacanTon();
            t1.Ukljuci();
            
            t1.ispisi();
            
            t1.DaLiJeUkljucen();
            
            t1.smanjiTon();
            t1.Iskljuci();
            
            t1.Ukljuci();
            t1.JacinaTona = 50;
            
            t1.ispisi();
        }
    }
}