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

            Point p3 = new Point(20, 20, '!');
            Point p4 = new Point(20, 2, '.');

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(2);
            numList.Add(4);
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            numList.RemoveAt(1);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
            

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            List<char> Simple = new List<char>();
            Simple.Add('+');
            Simple.Add('-');
            Simple.Add('*');
                     
            foreach(char v in Simple)
            {
                Console.WriteLine(v);
                Console.ReadLine();
            }

            List<Point> Target = new List<Point>();
            Target.Add(p1);
            Target.Add(p2);
            Target.Add(p3);
            Target.Add(p4);
            Console.WriteLine("Target: " + p3.x + p3.y + Target[1] + Target[2] + Target[3]);

            Console.ReadLine();
        }               
    }
}
