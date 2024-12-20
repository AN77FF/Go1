using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Models
{
        public class GoGame
        {
            private int[,] _board;
            private int _boardSize;
            private bool _isBlackTurn;
            public bool IsGameOver { get; private set; }

            public GoGame(int boardSize)
            {
                _boardSize = boardSize;
                _board = new int[boardSize, boardSize];
                _isBlackTurn = true;
                IsGameOver = false;
            }

            public void Start()
            {
                
                for (int i = 0; i < _boardSize; i++)
                {
                    for (int j = 0; j < _boardSize; j++)
                    {
                        _board[i, j] = 0;
                    }
                }
                IsGameOver = false;
            }

            public bool MakeMove(int x, int y)
            {
                if (IsGameOver || x < 0 || x >= _boardSize || y < 0 || y >= _boardSize || _board[x, y] != 0)
                {
                    return false; 
                }

                _board[x, y] = _isBlackTurn ? 1 : 2; 
                _isBlackTurn = !_isBlackTurn; 
                                              
                return true;
            }

            public void Reset()
            {
                Start();
            }

            public int[,] GetBoard()
            {
                return _board;
            }
        }
}

