using System;
/// <summary>
/// Решить задачу 8 коней
/// </summary>
namespace Problem_of_8_queens_8_knights
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 150;

            Console.WindowHeight = 40;
            ChessBoard board = new ChessBoard(8);
            board.Solve();
           
        }
    }
}
