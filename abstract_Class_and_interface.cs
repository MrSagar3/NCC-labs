using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_and_interface

{
    interface IShape
    {
        void Draw();
        int GetArea();
    }

    abstract class Shape
    {
        public abstract void Draw();

        public virtual int GetArea()
        {
            Console.WriteLine("Area calculation not implemented in base class");
            return 0;
        }
    }

    class Rectangle: Shape, IShape
    {
        private int width, height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle with width {0} and height {1}", width, height);
        }

        public override int GetArea()
        {
            return width * height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10);
            rect.Draw();
            Console.WriteLine("Area: {0}", rect.GetArea());
            Console.ReadKey();
        }
    }
}
