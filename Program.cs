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
            Console.SetBufferSize( 120, 30 );



            HorizontalLine upline = new HorizontalLine(0, 118, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(0, 118, 29, '+');
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 29, 0, '+');
            leftline.Drow();
            VerticalLine rightline = new VerticalLine(0, 29, 118, '+');
            rightline.Drow();

            List<char> CharList = new List<char>();
            CharList.Add('*');
            CharList.Add('#');
            CharList.Add('@');
            CharList.Add('$');

            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
