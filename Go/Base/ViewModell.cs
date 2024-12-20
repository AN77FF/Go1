using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Base
{
    
public abstract class ViewModell : IViewModel, INotifyPropertyChanged
    {
        protected string _gameStatus;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual string GameStatus
        {
            get => _gameStatus;
            protected set
            {
                _gameStatus = value;
                OnPropertyChanged(nameof(GameStatus));
            }
        }

        public abstract void StartGame();
        public abstract void MakeMove(int x, int y);
        public abstract void ResetGame();

        internal void MakeMove()
        {
            throw new NotImplementedException();
        }
    }
}


