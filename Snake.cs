﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            PList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point( tail );
                p.Move( i, direction );
                PList.Add( p );
            }
        }

        internal void Move()
        {
            Point tail = PList.First();
            PList.Remove( tail );
            Point head = GetNextPoint();
            PList.Add( head );

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = PList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                PList.Add(food);
                return true;
            }
            else
                return false;
          
        }

        internal bool IsHitTail()
        {
            var head = PList.Last();
            for(int i = 0; i < PList.Count - 2;i++)
            {
                if (head.IsHit(PList[i]))
                    return true;
            }
            return false;
        }
    }
}
