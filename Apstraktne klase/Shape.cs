using System.Dynamic;

namespace Apstraktne_klase
{
    public abstract class Shape
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Shape(string s)
        {
            Id = s;
        }
        
        public abstract double Area { get; }

        public override string ToString()
        {
            return Id + " Area = " + string.Format("{0:F2}", Area);
        }
    }
}