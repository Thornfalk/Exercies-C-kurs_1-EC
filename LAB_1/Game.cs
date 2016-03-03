using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise_3
{
    class Game
    {
        //Processing game method (Game Logic)
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
            string _title = string.Format("\n                       - CONWAY'S GAME OF LIFE -\n\n");
            Console.WriteLine(_title);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("  ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
