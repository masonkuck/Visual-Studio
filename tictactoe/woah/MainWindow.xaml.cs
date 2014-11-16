using System;
using System.Collections.Generic;
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

namespace woah
{
    public partial class MainWindow : Window
    {
        private bool gameStarted = false, player1 = true;
        private int[] grid = new int[9];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, RoutedEventArgs e)
        {
            player1 = false;

        }

        public string writeBlock(int blocknum, string current)
        {
            if (grid[blocknum] == 0)
            {
                if (player1 == true && grid[blocknum] != 2)
                {
                    grid[blocknum] = 1;
                    player1 = false;
                    return "X";
                }
                else if (player1 == false)
                {
                    grid[blocknum] = 2;
                    player1 = true;
                    return "O";
                }
                else
                {
                    return current;
                }
            }
            else
            {
                return current;
            }
        }

        private void tryWin()
        {

        }

        private void labelR1C1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR1C1.Content = writeBlock(0, labelR1C1.Content.ToString());
        }

        private void labelR1C2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR1C2.Content = writeBlock(1, labelR1C2.Content.ToString());
        }

        private void labelR1C3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR1C3.Content = writeBlock(2, labelR1C3.Content.ToString());

        }

        private void labelR2C1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR2C1.Content = writeBlock(3, labelR2C1.Content.ToString());

        }

        private void labelR2C2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR2C2.Content = writeBlock(4, labelR2C2.Content.ToString());

        }

        private void labelR2C3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR2C3.Content = writeBlock(5, labelR2C3.Content.ToString());

        }

        private void labelR3C1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR3C1.Content = writeBlock(6, labelR3C1.Content.ToString());

        }

        private void labelR3C2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR3C2.Content = writeBlock(7, labelR3C2.Content.ToString());

        }

        private void labelR3C3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            labelR3C3.Content = writeBlock(8, labelR3C3.Content.ToString());

        }

        private void resetGame_Click(object sender, RoutedEventArgs e)
        {
            for(int n = 0; n!=9; n++)
            {
                grid[n] = 0;
            }
            labelR1C1.Content = "";
            labelR1C2.Content = "";
            labelR1C3.Content = "";

            labelR2C1.Content = "";
            labelR2C2.Content = "";
            labelR2C3.Content = "";

            labelR3C1.Content = "";
            labelR3C2.Content = "";
            labelR3C3.Content = "";
        }
    }
}
