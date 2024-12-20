using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Base
{
        public interface IViewModel
        {
            event PropertyChangedEventHandler PropertyChanged;
            void StartGame();
            void MakeMove(int x, int y);
            void ResetGame();
            string GameStatus { get; }
        }
}

