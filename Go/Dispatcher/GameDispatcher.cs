using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Go.Base;

namespace Go.Dispatcher
{
    public class GameDispatcher : IDispatcher
    {
        private readonly ViewModell _viewModel;

        public GameDispatcher(ViewModell viewModel)
        {
            _viewModel = viewModel;
        }

        public void DispatchCommand(string command)
        {
            switch (command.ToLower())
            {
                case "start":
                    _viewModel.StartGame();
                    break;
                case "reset":
                    _viewModel.ResetGame();
                    break;
                case "makeMove":
                    _viewModel.MakeMove();
                    break;
                default:
                    throw new InvalidOperationException("Неизвестная команда.");
            }
        }
    }
}
