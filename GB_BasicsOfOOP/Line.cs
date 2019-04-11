using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_BasicsOfOOP
{
    class Line
    {
        protected List<Point> pList;

        /// <summary>
        /// Метод выводит линию в консоль
        /// </summary>
        public void Drow()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }

        /// <summary>
        /// Метод проверяет есть ли пересечение с линией
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        internal bool IsHit(Line line)
        {
            foreach (var p in pList)
            {
                if (line.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод проверяет есть ли пересечение с точкой
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal bool IsHit(Point p)
        {
            foreach (var i in pList)
            {
                if (i.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
