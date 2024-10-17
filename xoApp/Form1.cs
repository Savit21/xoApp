using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoApp
{
    public partial class Form1 : Form
    {
        Player currentPlayer;
        Player winner;

        int turn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public enum Player
        {
            X,
            O
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentPlayer = Player.X;
            lbWhoTrun.Text = $"{currentPlayer} Trun";
            turn++;
            labelTrun.Text = $"turn {turn}";
            btnReset.Tag = "reset";
        }

        private void buttonClick(object sender)
        {
            var button = (Button)sender;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
           
            if (currentPlayer == Player.X)
            {                
                button.BackColor = Color.LightGreen;
                currentPlayer = Player.O;
            }
            else
            {
                button.BackColor = Color.LightSalmon;
                currentPlayer = Player.X;
            }

            button.Tag = "play";

            turn++;
            labelTrun.Text = $"turn {turn}";
            lbWhoTrun.Text = $"{currentPlayer} Trun";
            CheckWinner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void CheckWinner()
        {
            if (
            button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
            button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
            button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
            button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
            button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
            button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
            button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
            button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
            {
                winner = Player.X;
                lbWhoTrun.Text = "X Win";
                WON();
            }
            else if (
            button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
            button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
            button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
            button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
            button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
            button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
            button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
            button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                winner = Player.O;
                lbWhoTrun.Text = "O Win";
                WON();
            }
            else if(turn >= 10)
            {
                lbWhoTrun.Text = "Draw";
            }
        }

        private void WON()
        {
            foreach (Control x in this.Controls)
            {
                string btntag = x.Tag == null ? string.Empty : x.Tag.ToString(); 
                if (x is Button && btntag != "reset")
                {
                    ((Button)x).Enabled = false;

                    if (x.Text != winner.ToString())
                    {
                        ((Button)x).BackColor = default(Color);
                    }         
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            turn = 1;
            labelTrun.Text = $"turn {turn}";
            currentPlayer = Player.X;
            lbWhoTrun.Text = $"{currentPlayer} Trun";

            foreach (Control x in this.Controls)
            {
                string btntag = x.Tag == null ? string.Empty : x.Tag.ToString();
                if (x is Button && btntag != "reset")
                {
                    ((Button)x).Enabled = true;
                    ((Button)x).Text = "";
                    ((Button)x).BackColor = Color.White;
                }
            }
        }
    }
}
