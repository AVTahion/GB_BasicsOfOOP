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

        /// <summary>
        /// Метод передвигает змею на одну точку
        /// </summary>
        internal void Move()
        {
            Point sTail = pList.First();
            pList.RemoveAt(0);
            Point sHead = GetHeadNew();
            pList.Add(sHead);

            sTail.Clear();
            sHead.Draw();
        }

        /// <summary>
        /// Метод получает точку перед головой змеи
        /// </summary>
        /// <returns></returns>
        private Point GetHeadNew()
        {
            Point sHead = pList.Last();
            Point sHeadNew = new Point(sHead);
            sHeadNew.Move(1, snakeDrctn);
            return sHeadNew;
        }

        /// <summary>
        /// Метод изминения направления движения змеи
        /// </summary>
        /// <param name="key"></param>
        internal void ChangeDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) snakeDrctn = Directions.LEFT;
            if (key == ConsoleKey.UpArrow) snakeDrctn = Directions.UP;
            if (key == ConsoleKey.RightArrow) snakeDrctn = Directions.RIGHT;
            if (key == ConsoleKey.DownArrow) snakeDrctn = Directions.DOWN;
        }

        /// <summary>
        /// Метод проверяет пересечение головы змеи с хвостом
        /// </summary>
        /// <returns></returns>
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод "поедания" точки еда
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
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
