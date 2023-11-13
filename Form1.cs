using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Flappybird_Click(object sender, EventArgs e)
        {

        }

        private void Gametimerevent(object sender, EventArgs e)
        {
            ErminBird.Top += gravity;
            Pipebottom.Left -= pipeSpeed;
            Pipetop.Left -= pipeSpeed;
            Scoretext.Text = "Score:  " + score; 

            if(Pipebottom.Left < -150)
            {
                Pipebottom.Left = 800;
                score++;
            }
            if(Pipetop.Left < -180)
            {
                Pipetop.Left = 950;
                score++;
            }
            if (ErminBird.Bounds.IntersectsWith(Pipebottom.Bounds) || 
                ErminBird.Bounds.IntersectsWith(Pipetop.Bounds) ||
                ErminBird.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();
            }

            if (score > 3)
            {
                pipeSpeed = 13;
            }

            if(ErminBird.Top < -25)
            {
                EndGame();
            }
        }

       
        private void GAmekeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void EndGame()
        {
            Gametimer.Stop();
            Scoretext.Text += "Game over!";
        }
    }
}
