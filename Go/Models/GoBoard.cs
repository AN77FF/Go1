using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Models
{
    public class GoBoard
    {
        public int Size { get; }
        public Stone[,] Board { get; private set; }

        public GoBoard(int size)
        {
            Size = size;
            Board = new Stone[size, size];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Board[i, j] = Stone.None;
                }
            }
        }
    }
}