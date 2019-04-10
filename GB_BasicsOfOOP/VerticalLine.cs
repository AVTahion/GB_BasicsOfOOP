using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_BasicsOfOOP
{
    class VerticalLine : Line
    {
        public VerticalLine(int x, int y1, int y2, char sym)
        {
            pList = new List<Point>();
            for (int i = y1; i < y2; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }
    }
}
