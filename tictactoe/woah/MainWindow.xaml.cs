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
        private int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, RoutedEventArgs e)
        {
            gameStarted = true;
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

            //this is a bunch of shit that i wrote because i totally forgot i wrote in a grid to make the logic easier.... *FACEDESK* MAYBE i will change this later. or maybe mike will want too ;D
            if (labelR1C1.Content.ToString() == labelR1C2.Content.ToString() && labelR1C2.Content.ToString() == labelR1C3.Content.ToString()
                && labelR1C1.Content.ToString() != "" && labelR1C2.Content.ToString() != "" && labelR1C3.Content.ToString() != "")//top row
            {
                if(player1!= true){MessageBox.Show("X Won!");}else{MessageBox.Show("O Won!");}
                gameStarted = false;
            }
            if (labelR1C1.Content.ToString() == labelR2C1.Content.ToString() && labelR2C1.Content.ToString() == labelR3C1.Content.ToString()
                && labelR1C1.Content.ToString() != "" && labelR2C1.Content.ToString() != "" && labelR3C1.Content.ToString() != "")//left column
            {
                if(player1!= true){MessageBox.Show("X Won!");}else{MessageBox.Show("O Won!");}
                gameStarted = false;
            }
            if (labelR1C1.Content.ToString() == labelR2C2.Content.ToString() && labelR2C2.Content.ToString() == labelR3C3.Content.ToString()
                && labelR1C1.Content.ToString() != "" && labelR2C2.Content.ToString() != "" && labelR3C3.Content.ToString() != "")//top left to bottom right
            {
                if(player1!= true){MessageBox.Show("X Won!");}else{MessageBox.Show("O Won!");}
                gameStarted = false;
            }
            if (labelR2C1.Content.ToString() == labelR2C2.Content.ToString() && labelR2C2.Content.ToString() == labelR2C3.Content.ToString()
                && labelR2C1.Content.ToString() != "" && labelR2C2.Content.ToString() != "" && labelR2C3.Content.ToString() != "")//middle row
            {
                if(player1!= true){MessageBox.Show("X Won!");}else{MessageBox.Show("O Won!");}
                gameStarted = false;
            }
            if (labelR3C1.Content.ToString() == labelR3C2.Content.ToString() && labelR3C2.Content.ToString() == labelR3C3.Content.ToString()
                && labelR3C1.Content.ToString() != "" && labelR3C2.Content.ToString() != "" && labelR3C3.Content.ToString() != "")//bottom row
            {
                if(player1!= true){MessageBox.Show("X Won!");}else{MessageBox.Show("O Won!");}
                gameStarted = false;
            }
            if (labelR3C1.Content.ToString() == labelR2C2.Content.ToString() && labelR2C2.Content.ToString() == labelR1C3.Content.ToString()
                && labelR3C1.Content.ToString() != "" && labelR2C2.Content.ToString() != "" && labelR1C3.Content.ToString() != "")//bottom left to top right
            {
                if(player1!= true){MessageBox.Show("X Won!");}else{MessageBox.Show("O Won!");}
                gameStarted = false;
            }
            if (labelR1C3.Content.ToString() == labelR2C3.Content.ToString() && labelR2C3.Content.ToString() == labelR3C3.Content.ToString()
                && labelR1C3.Content.ToString() != "" && labelR2C3.Content.ToString() != "" && labelR3C3.Content.ToString() != "")//right column
            {
                if (player1 != true) { MessageBox.Show("X Won!"); } else { MessageBox.Show("O Won!"); }
                gameStarted = false;
            }
            count = 0;
            foreach (int k in grid)
            {
                if (k != 0) count++;
                if (count == 9 && gameStarted == true)
                {
                    gameStarted = false;
                    MessageBox.Show("Tie");
                }
            }

        }

        private void labelR1C1_MouseUp(object sender, MouseButtonEventArgs e)
        {

            if (gameStarted == true) labelR1C1.Content = writeBlock(0, labelR1C1.Content.ToString());
            tryWin();
        }

        private void labelR1C2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (gameStarted == true) labelR1C2.Content = writeBlock(1, labelR1C2.Content.ToString());
            tryWin();
        }

        private void labelR1C3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (gameStarted == true) labelR1C3.Content = writeBlock(2, labelR1C3.Content.ToString());
            tryWin();

        }

        private void labelR2C1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (gameStarted == true) labelR2C1.Content = writeBlock(3, labelR2C1.Content.ToString());
            tryWin();

        }

        private void labelR2C2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (gameStarted == true) labelR2C2.Content = writeBlock(4, labelR2C2.Content.ToString());
            tryWin();

        }

        private void labelR2C3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (gameStarted == true) labelR2C3.Content = writeBlock(5, labelR2C3.Content.ToString());
            tryWin();

        }

        private void labelR3C1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (gameStarted == true) labelR3C1.Content = writeBlock(6, labelR3C1.Content.ToString());
            tryWin();

        }

        private void labelR3C2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (gameStarted == true) labelR3C2.Content = writeBlock(7, labelR3C2.Content.ToString());
            tryWin();

        }

        private void labelR3C3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (gameStarted == true) labelR3C3.Content = writeBlock(8, labelR3C3.Content.ToString());
            tryWin();

        }

        private void resetGame_Click(object sender, RoutedEventArgs e)
        {
            for (int n = 0; n != 9; n++)
            {
                grid[n] = 0;
            }
            gameStarted = false;
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
