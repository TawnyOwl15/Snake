using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, '*');
            p1.Draw();

            Point p2 = new Point(2, 8, '-');
            p2 = p1;
            p1.x = 15;
            p1.y = 16;       
            p2.Draw();
            Console.WriteLine("p1.x = " + p1.x + " p1.y = " + p1.y + " p2.x = " + p2.x + " p2.y = " + p2.y);
          
            Console.SetCursorPosition(2, 10);

            int x = 1;
            Func1(x);
            Console.WriteLine("Func1 называет x = " + x);

            Move(p1, 5, 5);
           

            Console.ReadLine();

        }

        static void Func1(int X)
        {
            X = X + 1;
        }
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
            Console.WriteLine("p.x = " + p.x + "; p.y = " + p.y);
        }
        public static void Reset(Point p)
        {
            p = new Point(10, 10, '+');
        }
    }
}
