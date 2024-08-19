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
        }

        private void buttonClick(object sender)
        {
            var button = (Button)sender;
            if(currentPlayer == Player.X)
            {
                currentPlayer = Player.O;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.LightGreen;
            }
            else
            {
                currentPlayer = Player.X;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.LightSalmon;
            }

            turn++;
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
    }
}
