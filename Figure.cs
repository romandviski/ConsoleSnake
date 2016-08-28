using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Figure
    {
        protected List<Point> PList;
        public void Drow()
        {
            foreach (Point p in PList)
            {
                p.Draw();
            }
        }

    }
}
