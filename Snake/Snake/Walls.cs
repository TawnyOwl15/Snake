using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> WallList;
        public Walls(int mapWidth, int mapHeist)
        {
            WallList = new List<Figure>();

            HorisontalLine lineDown = new HorisontalLine(0, mapWidth-2, mapHeist-1, '-');           
            HorisontalLine lineUp = new HorisontalLine(0, mapWidth - 2, 0, '-');         
            Line2 lineLeft = new Line2(0, 0, mapHeist-1, '-');         
            Line2 lineRight = new Line2(mapWidth-2, 0, mapHeist-1, '-');           

            WallList.Add(lineDown);
            WallList.Add(lineUp);
            WallList.Add(lineRight);
            WallList.Add(lineLeft);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in WallList)
            {
                if (wall.IsHit(figure))
                return true;                
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in WallList)
            {
                wall.Drow();
            }
        }
    }
}
