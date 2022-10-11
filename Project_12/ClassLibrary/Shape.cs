using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
     public class Shape
    {
        public int x { get; set; }
        public int y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
    }

    public class Square : Shape
    {
        public void Draw() // Without override executes base class method
        {
            Console.WriteLine("Drawing Square");
        }
    }
}
