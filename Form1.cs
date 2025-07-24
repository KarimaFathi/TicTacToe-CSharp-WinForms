using System;
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
        private void pic1I1_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (pic1I1.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic1I1.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic1I1.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic1I1.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic1I2_Click(object sender, EventArgs e)
        {
            if (pic1I2.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic1I2.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic1I2.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic1I2.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic1I3_Click(object sender, EventArgs e)
        {
            if (pic1I3.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic1I3.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic1I3.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic1I3.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic2I1_Click(object sender, EventArgs e)
        {

            if (pic2I1.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic2I1.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic2I1.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic2I1.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic2I2_Click(object sender, EventArgs e)
        {
            if (pic2I2.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic2I2.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic2I2.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic2I2.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic2I3_Click(object sender, EventArgs e)
        {
            if (pic2I3.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic2I3.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic2I3.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic2I3.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic3I1_Click(object sender, EventArgs e)
        {
            if (pic3I1.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic3I1.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic3I1.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic3I1.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic3I2_Click(object sender, EventArgs e)
        {
            if (pic3I2.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic3I2.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic3I2.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic3I2.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic3I3_Click(object sender, EventArgs e)
        {
            if (pic3I3.Tag == null)
            {
                if (player == enPlayer.player1)
                {
                    pic3I3.Image = Properties.Resources.X;
                    player = enPlayer.player2;
                }
                else
                {
                    pic3I3.Image = Properties.Resources.O;
                    player = enPlayer.player1;
                }
                pic3I3.Tag = true;
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
