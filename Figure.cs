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

        public virtual void Drow()
        {
            foreach (Point p in PList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in PList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in PList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
