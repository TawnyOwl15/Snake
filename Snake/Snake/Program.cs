using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, '*');
            Snake snake = new Snake(p1, 5, Direction.RIGHT);
            snake.Drow();

            Console.SetBufferSize(40, 15);

            HorisontalLine line = new HorisontalLine(0, 40, 0, '-');
            line.Drow();
            HorisontalLine line3 = new HorisontalLine(0, 40, 15, '-');
            line3.Drow();
            Line2 line2 = new Line2(0, 0, 15, '-');
            line2.Drow();
            Line2 line4 = new Line2(40, 0, 15, '-');
            line4.Drow();

            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();

        }               
    }
}
