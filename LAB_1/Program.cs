using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            int[,] arr = { 
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,},
                           { 0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,},
                           { 1,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                           { 1,1,0,0,0,0,0,0,0,0,1,0,0,0,1,0,1,1,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,},
                           { 0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,},
                           { 0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,} };

            //Creates a nice countdown :)
            var counter = 5;
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  " + counter);
                counter--;
            }
            System.Threading.Thread.Sleep(800);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            //Running and looping the cells
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                game.PrintToGrid(arr);
                System.Threading.Thread.Sleep(50);
                arr = game.ProcessingGame(arr);
            }
        }
    }
}
