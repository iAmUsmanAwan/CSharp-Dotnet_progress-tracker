using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToeWinForms
{
    public partial class Form1 : Form
    {
        private string currentPlayer = "X";
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            buttons = new Button[9];
            int btnSize = 100;
            this.Width = btnSize * 3 + 40;
            this.Height = btnSize * 3 + 100;
            this.Text = "Tic Tac Toe";

            for (int i = 0; i < 9; i++)
            {
                buttons[i] = new Button();
                buttons[i].Width = btnSize;
                buttons[i].Height = btnSize;
                buttons[i].Left = (i % 3) * btnSize + 10;
                buttons[i].Top = (i / 3) * btnSize + 10;
                buttons[i].Font = new System.Drawing.Font("Arial", 24);
                buttons[i].Click += Button_Click;
                this.Controls.Add(buttons[i]);
            }

            // Restart button
            Button resetButton = new Button();
            resetButton.Text = "Restart";
            resetButton.Width = 100;
            resetButton.Height = 30;
            resetButton.Top = btnSize * 3 + 20;
            resetButton.Left = 10;
            resetButton.Click += ResetButton_Click;
            this.Controls.Add(resetButton);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "")
            {
                btn.Text = currentPlayer;
                if (CheckWinner())
                {
                    MessageBox.Show($"{currentPlayer} wins!");
                    DisableButtons();
                }
                else if (buttons.All(b => b.Text != ""))
                {
                    MessageBox.Show("It's a draw!");
                }
                else
                {
                    currentPlayer = currentPlayer == "X" ? "O" : "X";
                }
            }
        }

        private bool CheckWinner()
        {
            int[,] wins = new int[,]
            {
                {0,1,2},{3,4,5},{6,7,8}, // Rows
                {0,3,6},{1,4,7},{2,5,8}, // Columns
                {0,4,8},{2,4,6}          // Diagonals
            };

            for (int i = 0; i < wins.GetLength(0); i++)
            {
                if (buttons[wins[i, 0]].Text == currentPlayer &&
                    buttons[wins[i, 1]].Text == currentPlayer &&
                    buttons[wins[i, 2]].Text == currentPlayer)
                {
                    return true;
                }
            }
            return false;
        }

        private void DisableButtons()
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (Button btn in buttons)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
            currentPlayer = "X";
        }
    }
}
