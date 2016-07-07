using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line2
    {
        List<Point> hList;
        public Line2(int x, int yUp, int yDown, char sym)
        {
            hList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                hList.Add(p);
            }
        }
        public void Drow()
        {
            foreach (Point p in hList)
            {
                p.Draw();
            }
        }
    }
}
