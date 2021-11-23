using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_of_8_queens_8_knights
{
    internal class ChessBoard
    {
        /// <summary>
        ///  Положение фигур в горизонталях шахматной доски
        ///  <para>Положение число от 0 до 7 </para>
        /// </summary>
        private int[] row;
        private bool[][] desk;
        private int horseCount = 27;
        internal ChessBoard(int size)
        {
            row = new int[size];
            desk = new bool[size][];
            for (int i = 0; i < size; i++)
            {
                row[i] = -1; // ферзи за полем
                desk[i] = new bool[size];
                for (int j = 0; j < size; j++)
                {
                    desk[i][j] = false;
                }
            }
        }
        /// <summary>
        /// Найти решение
        /// </summary>
        internal void Solve()
        {
            Run(0);
           // int countHorse = 0;
           //  RunHorse(0, 0, ref countHorse);
        }
        
        internal void RunHorse(int row, int col, ref int count)
        {
            for (int i = row; i < desk.Length; i++)
            {
                int cols = i == row ? col : 0;
                for (int j = cols; j < desk[i].Length; j++)
                {
                    if (AllowedHorse(i, j))
                    {
                        desk[i][j] = true;
                        count++;
                        if (count == horseCount)
                        {
                            PrintHorse();
                            desk[i][j] = false;
                            count--;
                        } else
                        {
                            RunHorse(i, j + 1, ref count);
                        }
                    }
                }
            }
            for (int i = desk.Length - 1; i >= 0; i--)
            {
                for (int j = desk.Length - 1; j >= 0; j--)
                {
                    if (desk[i][j])
                    {
                        desk[i][j] = false;
                        count--;
                        return;
                    }
                }
            }
        }
        private void PrintHorse()
        {
          

            for (int i = 0; i < row.Length; i++)
            {
                for (int j = 0; j < row.Length; j++)
                {
                    Console.BackgroundColor = ((i + j) % 2 == 1) ? ConsoleColor.Black : ConsoleColor.White;
                    Console.ForegroundColor = ((i + j) % 2 == 1) ? ConsoleColor.White : ConsoleColor.Black;
                    string s = (desk[i][j]) ? "<>" : "  ";
                    Console.Write(s);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private bool AllowedHorse(int row, int col)
        {
            for (int i = 1; i < 3; i++)
            {
                if (row - i >= 0)
                {
                    if (col - (3 - i) >= 0)
                    {
                        if (desk[row - i][col - (3 - i)])
                        {
                            return false;
                        }
                    }
                    if (col + (3- i) <= 7)
                    {
                        if (desk[row - i][col + (3 - i)])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void Print()
        {
            foreach(int i in row)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            for (int y = 0; y < row.Length; y++)
            {
                for (int x = 0; x < row.Length; x++)
                {
                    Console.BackgroundColor = ((x + y) % 2 == 1) ? ConsoleColor.Black : ConsoleColor.White;
                    Console.ForegroundColor = ((x + y) % 2 == 1) ? ConsoleColor.White : ConsoleColor.Black;
                    string s = (row[y] == x) ? "<>" : "  ";
                    Console.Write(s);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private bool Allowed(int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (row[i] == row[index])
                {
                    return false;
                }
                if (Math.Abs((row[index] - row[i])) == (index - i))
                {
                    return false;
                }
            }
            return true;
        }
        internal void Run(int index)
        {
            for (int pos = 0; pos < row.Length; pos++)
            {
                row[index] = pos;
                // проверить не под боем ли он

                if (!Allowed(index))
                {
                    continue;
                }
                if (index == row.GetUpperBound(0))
                {
                    Print();
                    //row[index] = -1;

                }
                else
                {
                    Run(index + 1);
                }
            }

        }
    }
}
