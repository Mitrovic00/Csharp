namespace Apstraktne_klase
{
    public class Square:Shape
    {
        private int side;

        public Square(int side, string id) : base(id)
        {
            this.side = side;
        }
        public override double Area
        {
            get
            {
                return side * side;
            }
        }
    }
}