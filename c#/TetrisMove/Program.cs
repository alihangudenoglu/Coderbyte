using System;
using System.Collections.Generic;

namespace TetrisMove
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] strArr = new string[] {"L", "3", "4", "4", "5", "6", "2", "0", "6", "5", "3", "6", "6" };
            //senboller oluşturuldu
            Dictionary<char, int[,]> sembols = new Dictionary<char, int[,]>
            {
                {'I',new int[1, 4] {{ 1,1,1,1}}},
                {'J',new int[2, 3] {{ 1,1,1},{ 0,0,1}}},
                {'L',new int[2, 3] {{ 1,1,1},{ 1,0,0}}},
                {'O',new int[2, 2] {{ 1,1},{ 1,1}}},
                {'S',new int[2, 3] {{ 0,1,1},{ 1,1,0}}},
                {'T',new int[2, 3] {{ 1,1,1},{ 0,1,0}}},
                {'Z',new int[2, 3] {{ 1,1,0},{ 0,1,1}}}
            };
            // static değerler
            int boardRow = 10;
            int boardCol = 12;
            int total = 0;
            int[,] board = new int[boardRow, boardCol];
            ReBoard(strArr,board);
            //verilen değerlerle tablo oluşturuldu
            static void ReBoard(string[] strArr, int[,] board)
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        board[(10 - 1 - j), i] = 0;
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < int.Parse(strArr[i + 1]); j++)
                    {
                        board[(10 - 1 - j), i] = 1;
                    }
                }
            }

            
            //uygun sembol boarda gezdiriliyor
            foreach (var item in sembols)
            {

                if (item.Key == char.Parse(strArr[0]))
                {
                    int[,] rotated = matRotate(item.Value, item.Value.GetLength(0), item.Value.GetLength(1));
                    for (int x = 0; x < 4; x++)
                    {
                        if (x != 0)
                        {
                            rotated = matRotate(rotated, rotated.GetLength(0), rotated.GetLength(1));
                        }
                        for (int m = 0; m <= boardRow - rotated.GetLength(0); m++)
                        {
                            for (int n = 0; n <= boardCol - rotated.GetLength(1); n++)
                            {
                                for (int i = 0; i < rotated.GetLength(0); i++)
                                {
                                    for (int j = 0; j < rotated.GetLength(1); j++)
                                    {
                                        if (board[m + i, n + j] == 1 && rotated[i, j] == 1)
                                        {
                                            goto LOAD;
                                        }
                                        else if (board[m + i, n + j] == 1 && rotated[i, j] == 0)
                                        {

                                        }
                                        else if (board[m + i, n + j] == 0)
                                        {
                                            board[m + i, n + j] = rotated[i, j];
                                        }
                                    }
                                }
                                if (LineCheck(boardRow, boardCol, board) != 0)
                                {
                                    int vl = LineCheck(boardRow, boardCol, board);
                                    total = total < vl ? vl : total;
                                }
                            LOAD:
                                ReBoard(strArr, board);
                            }

                        }
                    }
                }
            }
            //şekil döndürülüyor
            static int[,] matRotate(int[,] matrix, int row, int col)
            {
                int rowln = matrix.GetLength(0) == row ? col : row;
                int colln = matrix.GetLength(1) == row ? col : row;
                int[,] rotated = new int[rowln, colln];
                for (int i = 0; i < rowln; i++)
                {
                    for (int j = 0; j < colln; j++)
                    {
                        if (rowln > colln)
                        {
                            rotated[i, j] = matrix[colln - 1 - j, i];

                        }
                        else
                        {
                            rotated[i, j] = matrix[colln - 1 - j, i];
                        }
                    }
                }
                return rotated;
            }
            //satırların dolulukları kontrol ediliyor
            static int LineCheck(int row, int col, int[,] brd)
            {
                int counter = 0;
                int lineCounter = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (brd[i, j] == 1)
                        {
                            lineCounter++;
                        }
                    }
                    if (lineCounter == 12)
                    {
                        counter++;
                    }
                    lineCounter = 0;

                }

                return counter;
            }

            //boardı console üstünde göster
            for (int i = 0; i < boardRow; i++)
            {
                for (int j = 0; j < boardCol; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(total);
        }

    }
}
