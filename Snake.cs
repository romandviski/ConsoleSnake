using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            PList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point( tail );
                p.Move( i, direction );
                PList.Add( p );
            }
        }
    }
}
