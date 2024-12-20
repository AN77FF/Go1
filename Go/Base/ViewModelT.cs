using Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Base
{
        public class ViewModelT<T> : ViewModell
        {
            public T Model { get; private set; }
        public object Data { get; internal set; }

        private GoGame _game;

            public ViewModelT(GoGame game)
            {
                _game = game;
                GameStatus = "Игра не начата";
            }

            public override void StartGame()
            {
                _game.Start();
                GameStatus = "Игра начата";
            }

            public override void MakeMove(int x, int y)
            {
                if (_game.MakeMove(x, y))
                {
                    GameStatus = _game.IsGameOver ? "Игра окончена" : "Ход сделан";
                }
                else
                {
                    GameStatus = "Недопустимый ход!";
                }
            }

            public override void ResetGame()
            {
                _game.Reset();
                GameStatus = "Игра сброшена";
            }
        }
}

