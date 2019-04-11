using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_BasicsOfOOP
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point n)
        {
            x = n.x;
            y = n.y;
            sym = n.sym;
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        /// <summary>
        /// Метод сдвигает координаты точки на заданное расстояние в направлении direction
        /// </summary>
        /// <param name="offset">Расстояние смещения точки</param>
        /// <param name="direction">Направление смещения точки</param>
        public void Move(int offset, Directions direction)
        {
            if (direction == Directions.LEFT)
            {
                x = x - offset;
            }
            if (direction == Directions.RIGHT)
            {
                x = x + offset;
            }
            if (direction == Directions.UP)
            {
                y = y - offset;
            }
            if (direction == Directions.DOWN)
            {
                y = y + offset;
            }

        }

        internal bool IsHit(Point food)
        {
            return x == food.x && y == food.y;
        }

        /// <summary>
        /// Метод выводит точку в консоль
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
