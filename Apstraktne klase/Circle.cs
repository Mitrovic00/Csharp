using System;
using System.Net.Http.Headers;

namespace Apstraktne_klase
{
    public class Circle:Shape
    {
        private int radius;

        public Circle(int radius, string id) : base(id)
        {
            this.radius = radius;
        }
        public override double Area
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
    }
}