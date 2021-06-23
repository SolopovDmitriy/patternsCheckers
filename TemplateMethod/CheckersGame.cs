using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class CheckersGame : Game
    {
        private char[,] board;
        private int numberStep;

        public CheckersGame(int players) : base(players)
        {
            board = new char[8, 8];
            numberStep = 0;
        }

        public void Print()
        {
            Console.Write("   ");
            for (int j = 0; j < board.GetLength(1); j++)// рисуем буквы на доске
            {
                Console.Write((char)('A' + j) + " ");
            }
            Console.WriteLine();   
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write((i+1) + "  " ); // рисуем цифры на доске
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public override bool CheckWinner()// если CheckWinner, то игра заканчивается
        {
            return false;
        }

        public override void NextStep()
        {
            // a b c d e f g h 
            // 0 1 2 3 4 5 6 7 
           
            // 0 % 2 = 0
            // 1 % 2 = 1
            // 2 % 2 = 0
            // 3 % 2 = 1
            // 4 % 2 = 0
            // 123 % 2 = 1
            // 124 % 2 = 0

            _currentPlayer = numberStep % 2;//чередуются 0 и 1
            char currentCheker = 'b';
            if(_currentPlayer == 0)
            {
                currentCheker = 'w';
            }
            Console.WriteLine("player " + currentCheker);
            string step = Console.ReadLine(); // step = "c3b4" --> ввод с клавиатуры
            step = step.ToLower();
            int jFrom = step[0] - 'a'; // 'с' - 'а' = 97 - 95 = 2
            int iFrom = step[1] - '1'; // '3' - '1' = 2
            int jTo = step[2] - 'a';  //  'b' - 'а' = 96 - 95 = 1
            int iTo = step[3] - '1';

            if(Math.Abs(jFrom-jTo) == 2 && Math.Abs(iFrom - iTo) == 2) // с3e5
            {
                board[(iFrom + iTo) / 2, (jFrom + jTo) / 2] = 'o';// сЪели шашку
                //numberStep--;
            }
            board[iFrom, jFrom] = 'o';
            board[iTo, jTo] = currentCheker;
            numberStep++;
            Console.WriteLine();
            Print();

        }

        public override void Start() // стартовая позиция на доске
        {
            for (int i = 0; i < board.GetLength(0); i++)// заполняем пустыми клеточкам
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = 'o';
                }               
            }

            // white - заполняем доску белыми шашками
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if((i+j) % 2 == 0)
                    {
                        board[i, j] = 'w';
                    }                                 
                }                
            }

            // black
            for (int i = 5; i < 8; i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        board[i, j] = 'b';
                    }
                }
            }
            Print();
        }
    }
}
