using Go.Base;
using Go.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.ViewModel
{
public class GoViewModel : ViewModell
    {
        public GoBoard Board { get; set; }
        public ObservableCollection<Stone> Stones { get; set; }

        public GoViewModel()
        {
            Board = new GoBoard(19); 
            Stones = new ObservableCollection<Stone>();
        }

        public override void StartGame()
        {
            throw new NotImplementedException();
        }

        public override void MakeMove(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void ResetGame()
        {
            throw new NotImplementedException();
        }
    }
}

