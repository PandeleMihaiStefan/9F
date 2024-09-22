using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex
{
    public partial class TrexRunner : Form
    {
        bool jumping = false;
        bool isGameOver = false;
        Random random = new Random();
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position = 0;
        public TrexRunner()
        {
            InitializeComponent();
            GameReset();
        }

        private void GameReset()
        {
            jumping = false;
            force = 12;
            score = 0;
            jumpSpeed = 0;
            obstacleSpeed = 10;
            TrexPictureBox.Image = Properties.Resources.running;
            isGameOver = false;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 10);
                    x.Left = position;

                }
            }
            GameTimer.Start();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            TrexPictureBox.Top = TrexPictureBox.Top + jumpSpeed;

            ScoreLabel.Text = "Score: " + score + " Jumping speed: " + jumpSpeed + " force: " + force + " Top:" + TrexPictureBox.Top + " Bottom:" + TrexPictureBox.Bottom;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force--;
            }
            else if (TrexPictureBox.Top < 290)   
                {
                    jumpSpeed = 12;  
                }
                else
                { 
                    jumpSpeed = 0;
                    TrexPictureBox.Top = 290;  
                    force = 12;
                }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + random.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (TrexPictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        TrexPictureBox.Image = Properties.Resources.dead;
                        ScoreLabel.Text += " Press R to restart the game!";
                        isGameOver = true;
                        MessageBox.Show("Game Over");
                        break;
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void GameEvent(object sender, EventArgs e)
        {

        }

        private void TrexPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Obstacle1PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Obstacle2PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void FloorPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
    }
}
    
