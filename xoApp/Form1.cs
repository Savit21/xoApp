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
            turn++;
            labelTrun.Text = $"turn {turn}";
        }

        private void buttonClick(object sender)
        {
            var button = (Button)sender;
            if(currentPlayer == Player.X)
            {                
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.LightGreen;
                button.Tag = "play";
                currentPlayer = Player.O;
            }
            else
            {
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.LightSalmon;
                button.Tag = "play";
                currentPlayer = Player.X;
            }

            turn++;
            labelTrun.Text = $"turn {turn}";
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
                label1.Text = "X Wins";
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
                label1.Text = "O Wins";
            }else if(turn >= 10)
            {
                label1.Text = "Draw";
            }
        }

        //private void WON()
        //{
        //    foreach (Control x in this.Controls)
        //    {
        //        if (x is Button && x.Tag == "play")
        //        {
        //            ((Button)x).Enabled = false;
        //            ((Button)x).BackColor = default(Color);
        //        }
        //    }
        //}
    }
}
