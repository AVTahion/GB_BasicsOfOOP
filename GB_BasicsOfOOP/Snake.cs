using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_BasicsOfOOP
{
    class Snake : Line
    {
        public Directions snakeDrctn;

        public Snake(Point tail, int length, Directions _direction)
        {
            snakeDrctn = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point n = new Point(tail);
                n.Move(i, _direction);
                pList.Add(n);
            }
        }

        internal void Move()
        {
            Point sTail = pList.First();
            pList.RemoveAt(0);
            Point sHead = GetHeadNew();
            pList.Add(sHead);

            sTail.Clear();
            sHead.Draw();
        }

        private Point GetHeadNew()
        {
            Point sHead = pList.Last();
            Point sHeadNew = new Point(sHead);
            sHeadNew.Move(1, snakeDrctn);
            return sHeadNew;
        }

        internal void ChangeDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) snakeDrctn = Directions.LEFT;
            if (key == ConsoleKey.UpArrow) snakeDrctn = Directions.UP;
            if (key == ConsoleKey.RightArrow) snakeDrctn = Directions.RIGHT;
            if (key == ConsoleKey.DownArrow) snakeDrctn = Directions.DOWN;
        }

        internal bool Eat(Point food)
        {
            Point head = GetHeadNew();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            return false;
        }
    }
}
