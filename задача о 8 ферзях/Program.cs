using System;
/// <summary>
/// Решить задачу 8 коней
/// </summary>
namespace задача_о_8_ферзях
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
