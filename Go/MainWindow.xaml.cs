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
            public MainWindow()
            {
                InitializeComponent();
                DataContext = new GoViewModel();
            }

            private void StartGame_Click(object sender, RoutedEventArgs e)
            {
            MessageBox.Show("Игра начата!");
            }
        private void ResetGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Игра сброшена!");
        }
        private void Cell_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Игра");

        }
    }
}





