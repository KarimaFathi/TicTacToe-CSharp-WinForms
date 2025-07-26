﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_toe
{
    enum enPlayer { player1 = 1, player2 = 2 };
    public partial class Form1 : Form
    {
        enPlayer player = enPlayer.player1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen Pen = new Pen(white);

            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 400, 85, 400, 370);
            e.Graphics.DrawLine(Pen, 540, 85, 540, 370);
            e.Graphics.DrawLine(Pen, 290, 175, 650, 175);
            e.Graphics.DrawLine(Pen, 290, 270, 650, 270);
        }

        private void HandlePlayerMove(PictureBox picBox)
        {
            if (picBox.Tag != null)
            {
                MessageBox.Show("Invalid move. Please choose an empty cell.", "Invalid Move", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (player == enPlayer.player1)
            {
                picBox.Image = Properties.Resources.X;
                picBox.Tag = "X";
                player = enPlayer.player2;
                lbPlayerTurn.Text = "Player 2";
            }
            else
            {
                picBox.Image = Properties.Resources.O;
                picBox.Tag = "O";
                player = enPlayer.player1;
                lbPlayerTurn.Text = "Player 1";
            }

            CheckWinner();
        }
        private void pic1I1_MouseClick(object sender, MouseEventArgs e)
        {

            HandlePlayerMove(pic1I1);
        }

        private void pic1I2_Click(object sender, EventArgs e)
        {
            HandlePlayerMove(pic1I2);
        }

        private void pic1I3_Click(object sender, EventArgs e)
        {
            HandlePlayerMove(pic1I3);
        }

        private void pic2I1_Click(object sender, EventArgs e)
        {

            HandlePlayerMove(pic2I1);
        }

        private void pic2I2_Click(object sender, EventArgs e)
        {

            HandlePlayerMove(pic2I2);
        }

        private void pic2I3_Click(object sender, EventArgs e)
        {

            HandlePlayerMove(pic2I3);
        }

        private void pic3I1_Click(object sender, EventArgs e)
        {

            HandlePlayerMove(pic3I1);
        }

        private void pic3I2_Click(object sender, EventArgs e)
        {
            HandlePlayerMove(pic3I2);
        }

        private void pic3I3_Click(object sender, EventArgs e)
        {
            HandlePlayerMove(pic3I3);
        }

        private void CheckWinner()
        {
           
            if (
    (Convert.ToString(pic1I1.Tag) == "X" && Convert.ToString(pic1I2.Tag) == "X" && Convert.ToString(pic1I3.Tag) == "X") ||
    (Convert.ToString(pic2I1.Tag) == "X" && Convert.ToString(pic2I2.Tag) == "X" && Convert.ToString(pic2I3.Tag) == "X") ||
    (Convert.ToString(pic1I1.Tag) == "X" && Convert.ToString(pic2I1.Tag) == "X" && Convert.ToString(pic3I1.Tag) == "X") ||
    (Convert.ToString(pic1I2.Tag) == "X" && Convert.ToString(pic2I2.Tag) == "X" && Convert.ToString(pic3I2.Tag) == "X") ||
    (Convert.ToString(pic1I3.Tag) == "X" && Convert.ToString(pic2I3.Tag) == "X" && Convert.ToString(pic3I3.Tag) == "X") ||
    (Convert.ToString(pic1I1.Tag) == "X" && Convert.ToString(pic2I2.Tag) == "X" && Convert.ToString(pic3I3.Tag) == "X") ||
    (Convert.ToString(pic1I3.Tag) == "X" && Convert.ToString(pic2I2.Tag) == "X" && Convert.ToString(pic3I1.Tag) == "X") 
)
            {
                lbGameWinner.Text = "Player 1";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (
    (Convert.ToString(pic1I1.Tag) == "O" && Convert.ToString(pic1I2.Tag) == "O" && Convert.ToString(pic1I3.Tag) == "O") ||
    (Convert.ToString(pic2I1.Tag) == "O" && Convert.ToString(pic2I2.Tag) == "O" && Convert.ToString(pic2I3.Tag) == "O") ||
    (Convert.ToString(pic3I1.Tag) == "O" && Convert.ToString(pic3I2.Tag) == "O" && Convert.ToString(pic3I3.Tag) == "O") ||
    (Convert.ToString(pic1I1.Tag) == "O" && Convert.ToString(pic2I1.Tag) == "O" && Convert.ToString(pic3I1.Tag) == "O") ||
    (Convert.ToString(pic1I2.Tag) == "O" && Convert.ToString(pic2I2.Tag) == "O" && Convert.ToString(pic3I2.Tag) == "O") ||
    (Convert.ToString(pic1I3.Tag) == "O" && Convert.ToString(pic2I3.Tag) == "O" && Convert.ToString(pic3I3.Tag) == "O") ||
    (Convert.ToString(pic1I1.Tag) == "O" && Convert.ToString(pic2I2.Tag) == "O" && Convert.ToString(pic3I3.Tag) == "O") ||
    (Convert.ToString(pic1I3.Tag) == "O" && Convert.ToString(pic2I2.Tag) == "O" && Convert.ToString(pic3I1.Tag) == "O")
                )
            {
                lbGameWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (pic1I1.Tag != null && pic1I2.Tag != null && pic1I3 != null &&
                    pic2I1.Tag != null && pic2I2.Tag != null && pic2I3.Tag != null &&
                    pic3I1.Tag != null && pic3I2.Tag != null && pic3I3.Tag != null)
                {
                    lbGameWinner.Text = "Drain";
                    MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            pic1I1.Image = Properties.Resources.question_mark_96;
            pic1I2.Image = Properties.Resources.question_mark_96;
            pic1I3.Image = Properties.Resources.question_mark_96;
            pic2I1.Image = Properties.Resources.question_mark_96;
            pic2I2.Image = Properties.Resources.question_mark_96;
            pic2I3.Image = Properties.Resources.question_mark_96;
            pic3I1.Image = Properties.Resources.question_mark_96;
            pic3I2.Image = Properties.Resources.question_mark_96;
            pic3I3.Image = Properties.Resources.question_mark_96;

            pic1I1.Tag = null;
            pic1I2.Tag = null;
            pic1I3.Tag = null;
            pic2I1.Tag = null;
            pic2I2.Tag = null;
            pic2I3.Tag = null;
            pic3I1.Tag = null;
            pic3I2.Tag = null;
            pic3I3.Tag = null;

            lbGameWinner.Text = "In Progress";

            player = enPlayer.player1;

            lbPlayerTurn.Text = "Player 1";

        }
    }
}
