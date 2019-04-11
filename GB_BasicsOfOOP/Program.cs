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
            int windowWidth = 120;
            int windowHeight = 30;
            Console.SetWindowSize(windowWidth, windowHeight);
            Console.SetBufferSize(windowWidth, windowHeight);
            Console.CursorVisible = false;

            Walls walls = new Walls(windowWidth, windowHeight);
            walls.Draw();

            Point p1 = new Point(4, 5, '#');
            Snake s = new Snake(p1, 4, Directions.RIGHT);
            s.Drow();

            FoodCreator foodCrtr = new FoodCreator(windowWidth - 3, windowHeight - 3, '@');
            Point food = foodCrtr.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(s) || s.IsHitTail())
                {
                    break;
                }
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

            Console.SetCursorPosition(55, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("GAME OVER!");
            Console.ReadKey();
        }
    }
}
