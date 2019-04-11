using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GB_BasicsOfOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Console.BufferWidth, 30);

            HorizontalLine hLineTop = new HorizontalLine(0, Console.BufferWidth, 1, '=');
            hLineTop.Drow();
            HorizontalLine hLineBottom = new HorizontalLine(0, Console.BufferWidth, 29, '=');
            hLineBottom.Drow();
            VerticalLine vLineL = new VerticalLine(0, 0, Console.BufferHeight, '|');
            vLineL.Drow();
            VerticalLine vLineR = new VerticalLine(118, 0, Console.BufferHeight, '|');
            vLineR.Drow();

            Point p1 = new Point(4, 5, '#');
            Snake s = new Snake(p1, 4, Directions.RIGHT);
            s.Drow();

            FoodCreator foodCrtr = new FoodCreator(118, 29, '@');
            Point food = foodCrtr.CreateFood();
            food.Draw();

            while (true)
            {
                if (s.Eat(food))
                {
                    food = foodCrtr.CreateFood();
                    food.Draw();
                }
                else s.Move();
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    s.ChangeDirection(key.Key);
                }
            }

            Console.ReadKey();
        }
    }
}
