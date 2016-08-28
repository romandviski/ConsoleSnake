using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 120, 30 );
            Console.WriteLine("Нажмите enter, чтобы начать");
            Console.ReadLine();


            HorizontalLine upline = new HorizontalLine(0, 118, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(0, 118, 29, '+');
            downline.Drow();
            VerticalLine leftline = new VerticalLine(0, 29, 0, '+');
            leftline.Drow();
            VerticalLine rightline = new VerticalLine(0, 29, 118, '+');
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(120, 30, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            //Console.ReadLine();
        }
    }
}
