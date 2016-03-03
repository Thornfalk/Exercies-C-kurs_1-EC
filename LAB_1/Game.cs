using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise_3
{
    class Game
    {
        //Processing game method (Logic)
        public int[,] ProcessingGame(int[,] arr)
        {
            int[,] temp = new int[20,38];
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int _countNumberOfCells = CountNumberOfCells(i, j, arr);

                    if (arr[i, j] == 1)
                    {
                        if (_countNumberOfCells == 2 || _countNumberOfCells == 3)
                        {
                            temp[i, j] = 1;
                        }
                        else
                        {
                            temp[i, j] = 0;
                        }
                    }
                    else if (arr[i, j] == 0)
                    {
                        if (_countNumberOfCells == 3)
                        {
                            temp[i, j] = 1;
                        }
                        else
                        {
                            temp[i, j] = 0;
                        }
                    }
                }
            }
            return temp;   
        }

        //Controlling nearby Cells
        int CountNumberOfCells(int i, int j, int[,] arr)
        {
            int _countNumberOfCells = 0;

            try
            {
                if (arr[i - 1, j - 1] == 1)
                    _countNumberOfCells += 1;
            }
            catch { }
            try
            {
                if (arr[i - 1, j] == 1)
                    _countNumberOfCells += 1;
            }
            catch { }
            try
            {
                if (arr[i - 1, j + 1] == 1)
                    _countNumberOfCells += 1;
            }
            catch { }
            try
            {
                if (arr[i, j - 1] == 1)
                    _countNumberOfCells += 1;
            }
            catch { }
            try
            {
                if (arr[i, j + 1] == 1)
                    _countNumberOfCells += 1;
            }
            catch { }
            try
            {
                if (arr[i + 1, j - 1] == 1)
                    _countNumberOfCells += 1;
            }
            catch { }
            try
            {
                if (arr[i + 1, j] == 1)
                    _countNumberOfCells += 1;
            }
            catch { }
            try
            {
                if (arr[i + 1, j + 1] == 1)
                    _countNumberOfCells += 1;
            }
            catch { }

            return _countNumberOfCells;
        }

        //Prints grid
        public void PrintToGrid(int[,] arr)
        {
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                - CONWAY'S GAME OF LIFE - \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //Console.Write(" - ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("  ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.White;

                        //int redOrBlue = rand.Next(2);
                        //if (redOrBlue == 1)
                        //{
                        //    //Console.ForegroundColor = ConsoleColor.Red;
                        //    //Console.Write(">");
                        //    //Console.ForegroundColor = ConsoleColor.Red;
                        //    //Console.Write("*");
                        //    //Console.ForegroundColor = ConsoleColor.Red;
                        //    Console.Write("<");
                        //}
                        //else
                        //{
                        //    //Console.ForegroundColor = ConsoleColor.Blue;
                        //    //Console.Write("<");
                        //    //Console.ForegroundColor = ConsoleColor.Blue;
                        //    //Console.Write("*");
                        //    //Console.ForegroundColor = ConsoleColor.Blue;
                        //    Console.Write(">");
                        //}
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
