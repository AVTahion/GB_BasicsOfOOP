using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_BasicsOfOOP
{
    class HorizontalLine : Line
    {
        public HorizontalLine(int x1, int x2, int y, char sym)
        {
            pList = new List<Point>();
            for (int i = x1; i < x2; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }
    }
}
