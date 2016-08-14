using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine hline = new HorizontalLine(1, 10, 1, '+');
            hline.Drow();

            VerticalLine vline = new VerticalLine(1, 10, 1, '+');
            vline.Drow();

            List<char> CharList = new List<char>();
            CharList.Add('*');
            CharList.Add('#');
            CharList.Add('@');
            CharList.Add('$');

                Point p1 = new Point(2, 3, CharList[0]);
                Point p2 = new Point(4, 5, CharList[1]);
                Point p3 = new Point(6, 8, CharList[2]);
                Point p4 = new Point(10, 13, CharList[3]);

            List<Point> PointList = new List<Point>();
            PointList.Add(p1);
            PointList.Add(p2);
            PointList.Add(p3);
            PointList.Add(p4);

            foreach(Point i in PointList)
            {
                i.Draw();
            }

            Console.ReadLine();
        }
    }
}
