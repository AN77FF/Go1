using Go.Base;
using Go;
using Go.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Go.ViewModel;

namespace Go
{
    public partial class MainWindow : Window
    {
        private const int BoardSize = 19;
        private Button[,] cells;
        private int[,] board; 
        private bool isPlayerOneTurn;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();
            DataContext = new GoViewModel();
        }

        private void InitializeGame()
        {
            isPlayerOneTurn = true; 
            board = new int[BoardSize, BoardSize];
            cells = new Button[BoardSize, BoardSize];
            GameBoard.Children.Clear();

            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    Button cell = new Button
                    {
                        Background = Brushes.Beige,
                        Margin = new Thickness(1)
                    };
                    cell.Click += (sender, e) => CellClicked(x, y);
                    cells[x, y] = cell;
                    GameBoard.Children.Add(cell);
                }
            }
        }

        private void CellClicked(int x, int y)
        {
            if (board[x, y] != 0) return;
            board[x, y] = isPlayerOneTurn ? 1 : 2; 
            cells[x, y].Background = isPlayerOneTurn ? Brushes.Black : Brushes.White;

            
            CaptureOpponents(x, y);
            isPlayerOneTurn = !isPlayerOneTurn;
        }

        private void CaptureOpponents(int x, int y)
        {
            List<(int, int)> groupToCapture = new List<(int, int)>();
            int opponentColor = isPlayerOneTurn ? 2 : 1;

            
            CheckCapture(x, y, opponentColor, groupToCapture);

            if (groupToCapture.Count > 0)
            {
                foreach (var (gx, gy) in groupToCapture)
                {
                    board[gx, gy] = 0;
                    cells[gx, gy].Background = Brushes.Beige; 
                }
            }

            
            if (IsGameOver())
            {
                EndGame();
            }
        }

        private void CheckCapture(int x, int y, int opponentColor, List<(int, int)> groupToCapture)
        {
            Stack<(int, int)> stack = new Stack<(int, int)>();
            bool hasLiberty = false;
            stack.Push((x, y));
            HashSet<(int, int)> visited = new HashSet<(int, int)>();

            while (stack.Count > 0)
            {
                var (cx, cy) = stack.Pop();
                if (visited.Contains((cx, cy))) continue;
                visited.Add((cx, cy));

                
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        if (Math.Abs(dx) == Math.Abs(dy)) continue; 
                        int nx = cx + dx;
                        int ny = cy + dy;

                        if (nx < 0 || nx >= BoardSize || ny < 0 || ny >= BoardSize) continue;

                        if (board[nx, ny] == opponentColor)
                        {
                            groupToCapture.Add((nx, ny));
                            stack.Push((nx, ny)); 
                        }
                        else if (board[nx, ny] == 0)
                        {
                            hasLiberty = true; 
                        }
                    }
                }
            }

            
            if (!hasLiberty)
            {
                foreach (var pos in groupToCapture)
                {
                    board[pos.Item1, pos.Item2] = 0; 
                }
            }
            else
            {
                groupToCapture.Clear(); 
        
        }

        private bool IsGameOver()
        {
            
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (board[x, y] == 0) return false; 
                }
            }
            return true;
        }

        private void EndGame()
        {
            
            int blackScore = 0, whiteScore = 0;

            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (board[x, y] == 1) blackScore++; 
                    else if (board[x, y] == 2) whiteScore++; 
                }
            }

            string winner = blackScore > whiteScore ? "Черный победил!" : (whiteScore > blackScore ? "Белый победил!" : "Ничья!");
            MessageBox.Show($"Игра окончена! {winner}\nОчки: Черный - {blackScore}, Белый - {whiteScore}");
            InitializeGame(); 
        }
    }
}

                
            
