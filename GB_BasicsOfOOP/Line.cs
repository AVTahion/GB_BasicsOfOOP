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

    }
}
