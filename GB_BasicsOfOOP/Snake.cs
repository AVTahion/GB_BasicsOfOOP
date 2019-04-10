using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_BasicsOfOOP
{
    class Snake : Line
    {
        public Snake(Point tail, int length, Directions direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point n = new Point(tail);
                n.Move(i, direction);
                pList.Add(n);
            }
        }
    }
}
