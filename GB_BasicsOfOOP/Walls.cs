using System;
using System.Collections.Generic;

namespace GB_BasicsOfOOP
{
    internal class Walls
    {
        List<Line> wallsList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallsList = new List<Line>();

            HorizontalLine hLineTop = new HorizontalLine(1, mapWidth - 1, 1, '#');
            HorizontalLine hLineBottom = new HorizontalLine(1, mapWidth - 1, mapHeight - 2, '#');
            VerticalLine vLineL = new VerticalLine(1, 1, mapHeight - 2, '#');
            VerticalLine vLineR = new VerticalLine(mapWidth - 2, 1, mapHeight - 2, '#');

            wallsList.Add(hLineTop);
            wallsList.Add(hLineBottom);
            wallsList.Add(vLineL);
            wallsList.Add(vLineR);
        }

        /// <summary>
        /// Метод отрисовывает стены в консоли
        /// </summary>
        public void Draw()
        {
            foreach (var wall in wallsList)
            {
                wall.Drow();
            }
        }

        /// <summary>
        /// Метод проверяет есть ли пересечение смо стенами
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        internal bool IsHit(Line line)
        {
            foreach (var wall in wallsList)
            {
                if (wall.IsHit(line))
                {
                    return true;
                }
            }
            return false;
        }
    }
}