using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int posX = Console.WindowWidth / 2;
            int posY = Console.WindowHeight / 2;

            int vecchiaX;
            int vecchiaY;

            int melaX = 0;
            int melaY = 0;

            int score = 0;

            ConsoleKeyInfo tasto = Console.ReadKey(true);


            DisegnaAsterisco(posX, posY);
            
            RndMela(out melaX, out melaY);
            
            do
            {
                tasto = Console.ReadKey(true);

                vecchiaX = posX;
                vecchiaY = posY;

                if (tasto.Key == ConsoleKey.UpArrow)
                {
                    posY--;
                }
                else if(tasto.Key == ConsoleKey.DownArrow)
                {
                    posY++;
                }
                else if (tasto.Key == ConsoleKey.LeftArrow)
                {
                    posX--;
                }
                else if (tasto.Key == ConsoleKey.RightArrow)
                {
                    posX++;
                }

                if (posX == melaX && posY == melaY)
                {
                    score++;
                    RndMela(out melaX, out melaY);
                }

                if (posX == Console.WindowWidth || posY == Console.WindowHeight ||
                    posX < 0 || posY < 0)
                {
                    break;
                }

                if(score > 1 && tasto.Key == ConsoleKey.UpArrow)
                {
                    for (int i = 0; i < score; i++)
                    {
                        DisegnaAsterisco(posX, posY - 1);
                    }
                }

                DisegnaSpazio(vecchiaX, vecchiaY);
                DisegnaAsterisco(posX, posY);

            }
            while (true);
            GameOver();
        }


        private static void RndMela(out int melaX, out int melaY)
        {
            melaX = rnd.Next(1, Console.WindowWidth - 1);
            melaY = rnd.Next(1, Console.WindowHeight - 1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(melaX, melaY);
            Console.Write('O');
            Console.ResetColor();
        }

        private static void DisegnaSpazio(int left, int top)
        {
            Thread.Sleep(1);
            Console.SetCursorPosition(left, top);
            Console.Write(' ');
        }

        private static void DisegnaAsterisco(int left, int top)
        {
            Thread.Sleep(1);
            Console.SetCursorPosition(left, top);
            Console.Write('*');
        }
        private static void GameOver()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Game Over.");
        }
    }
}
