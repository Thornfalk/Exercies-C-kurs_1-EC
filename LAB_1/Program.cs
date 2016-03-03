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
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0},
                           { 1,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 1,1,0,0,0,0,0,0,0,0,1,0,0,0,1,0,1,1,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0} };


            //int[,] arr = new int[20, 20];
            //Random rand = new Random();
            //for (int i = 0; i < 80; i++)
            //{
            //    int X = rand.Next(20);
            //    int Y = rand.Next(20);
            //    arr[X, Y] = 1;
            //}
            
            //Creates a nice countdown :)
            //for (int i = 0; i < 15; i++)
            //{
            //    System.Threading.Thread.Sleep(100);
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write(" -");
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.Write("- ");
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //}
            //Console.BackgroundColor = ConsoleColor.Black;
            
            //Running and looping the cells
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                game.PrintToGrid(arr);
                System.Threading.Thread.Sleep(30);
                arr = game.ProcessingGame(arr);
            }
        }
    }
}
