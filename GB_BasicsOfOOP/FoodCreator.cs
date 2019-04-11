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

        internal Point CreateFood()
        {
            int x = rnd.Next(2, mapWidth);
            int y = rnd.Next(2, mapHeight);
            return new Point(x, y, sym);
        }
    }
}