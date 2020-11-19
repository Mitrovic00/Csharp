namespace Apstraktne_klase
{
    public class Rectangle:Shape
    {
        private int width;
        private int height;

        public Rectangle(int w, int h,  string id) : base(id)
        {
            width = w;
            height = h;
        }
        public override double Area
        {
            get
            {
                return width * height;
            }
        }
    }
}