using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                Console.WriteLine("Enter the board size: ");
                int size = int.Parse(Console.ReadLine());
                int[,] board = new int[size + 1, size + 1];
                for (int i = 1; i < board.GetLength(1); i++)
                {
                    for (int k = 1; k < board.GetLength(0); k++)
                    {
                        board[i, k] = i * k;
                    }
                }

                for (int i = 1; i < board.GetLength(1); i++)
                {
                    for (int k = 1; k < board.GetLength(0); k++)
                    {
                        if (board[i, k] % size == 0 && (i != size && k != size))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (board[i, k] < 10)
                                Console.Write(board[i, k] + "   ");
                            else if (board[i, k] < 100)
                                Console.Write(board[i, k] + "  ");
                            else
                                Console.Write(board[i, k] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            if (board[i, k] < 10)
                                Console.Write(board[i, k] + "   ");
                            else if (board[i, k] < 100)
                                Console.Write(board[i, k] + "  ");
                            else
                                Console.Write(board[i, k] + " ");
                        }

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
//זכויות יוצרים למגניבים המדליקים   