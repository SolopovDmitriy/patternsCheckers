using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
   abstract class Game
   {
        protected int _countPlayers;

        protected int _currentPlayer;
        public abstract void Start();

        public abstract void NextStep();

        public abstract bool CheckWinner();
        public Game(int countPlayers)
        {
            _countPlayers = countPlayers;
        }
        public void Run()
        {
            Start();
            while (!CheckWinner())
            {
                NextStep();
            }
            Console.WriteLine($"Игра окончена, победитель: {_currentPlayer}");
        }
    }
}
