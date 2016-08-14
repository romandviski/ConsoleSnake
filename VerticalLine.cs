using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class VerticalLine
    {
        List<Point> PList;

        public VerticalLine(int yTop, int yDown, int x, char sym)
        {
            PList = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                PList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in PList)
            {
                p.Draw();
            }
        }



    }
}