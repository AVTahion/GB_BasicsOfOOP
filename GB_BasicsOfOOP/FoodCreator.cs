using System;

namespace GB_BasicsOfOOP
{
    internal class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private char sym;

        Random rnd = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        /// <summary>
        /// Метод создает еду на карте
        /// </summary>
        /// <returns></returns>
        internal Point CreateFood()
        {
            int x = rnd.Next(3, mapWidth);
            int y = rnd.Next(3, mapHeight);
            return new Point(x, y, sym);
        }
    }
}