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
            int[] posX = new int[100];
            int[] posY = new int[100];

            posX[0] = Console.WindowWidth / 2;
            posY[0] = Console.WindowHeight / 2;


            int melaX = 0;
            int melaY = 0;

            int dirY = 0;
            int dirX = 1;

            int score = 1;

            ConsoleKeyInfo tasto = Console.ReadKey(true);


            DisegnaAsterisco(posX[0], posY[0]);
            
            RndMela(out melaX, out melaY);
            
            do
            {

                DisegnaSpazio(posX[score - 1], posY[score - 1]);
                
                if (Console.KeyAvailable)
                {
                    tasto = Console.ReadKey(true);

                    if (tasto.Key == ConsoleKey.UpArrow)
                    {
                        dirX = 0;
                        dirY = -1;
                    }
                    else if(tasto.Key == ConsoleKey.DownArrow)
                    {
                        dirX = 0;
                        dirY = 1;
                    }
                    else if (tasto.Key == ConsoleKey.LeftArrow)
                    {
                        dirX = -1;
                        dirY = 0;
                    }
                    else if (tasto.Key == ConsoleKey.RightArrow)
                    {
                        dirX = 1;
                        dirY = 0;
                    }
                }

                for (int i = score - 1; i > 0; i--)
                {
                    posX[i] = posX[i - 1];
                    posY[i] = posY[i - 1];
                }

                posX[0] += dirX;
                posY[0] += dirY;

                if (posX[0] == melaX && posY[0] == melaY)
                {
                    score++;
                    RndMela(out melaX, out melaY);
                }

                if (posX[0] == Console.WindowWidth || posY[0] == Console.WindowHeight ||
                    posX[0] < 0 || posY[0] < 0)
                {
                    break;
                }


                DisegnaAsterisco(posX[0], posY[0]);
                
                Thread.Sleep(100);

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
            Console.SetCursorPosition(left, top);
            Console.Write(' ');
        }

        private static void DisegnaAsterisco(int left, int top)
        {
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
