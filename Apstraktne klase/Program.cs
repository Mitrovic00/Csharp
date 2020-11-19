﻿using System;

namespace Apstraktne_klase
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes =
            {
                new Square(5, "Square #1"),
                new Circle(3, "Circle #1"),
                new Rectangle(4, 5, "Rectangle #1")
            };
            Console.WriteLine("Shapes Collection");

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}