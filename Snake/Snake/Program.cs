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
            p2.Draw();

            HorisontalLine line = new HorisontalLine(0,15,20,'-');
            line.Drow();
            
            Line2 line2 = new Line2(17, 10, 30, '+');
            line2.Drow();

            Console.ReadLine();

        }               
    }
}
