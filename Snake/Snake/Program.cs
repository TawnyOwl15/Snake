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
           
            Console.SetBufferSize(80, 25);

            HorisontalLine lineDown = new HorisontalLine(0, 79, 24, '-');
            lineDown.Drow();
            HorisontalLine lineUp = new HorisontalLine(0, 79, 0, '-');
            lineUp.Drow();
            Line2 lineLeft = new Line2(0, 0, 23, '-');
            lineLeft.Drow();
            Line2 lineRight = new Line2(79, 0, 23, '-');
            lineRight.Drow();

            Point p = new Point(1, 1, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(79, 23, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Hand1(key.Key);
                }
            }
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Hand1(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            
        }               
    }
}
