using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.Polymorphism
{
    class Polymorphism
    {
        public static void Main()
        {
            //Shape shape = new Rectangle();
            //shape.Draw(); // Drawing Shape -  Calls the Reference Type Method

            DrawShape(new Rectangle());
            DrawShape(new Triangle());
            DrawShape(new Circle());
        }
        public static void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
    interface IShape
    {
        void Draw();
    }
    class Circle : IShape //Realization
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
    class Triangle : IShape {
        public void Draw()
        {
            Console.WriteLine("Drawing Triangle...");
        }
    }
    class Rectangle : IShape {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
}
