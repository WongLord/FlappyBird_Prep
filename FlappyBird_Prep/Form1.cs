using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_Prep
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 15;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            lblScore.Text = $"Score: {score}";

            if (pipeBottom.Left < -120)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (pipeTop.Left < -150)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
                GameOver();

            //if (score ==4)
            //    pipeSpeed = 15;

            //if (score == 6)
            //    pipeSpeed = 20;

            //if (score == 10)
            //    pipeSpeed = 25;

            pipeSpeed = score switch
            {
                4 => 15,
                6 => 20,
                10 => 25,
                15 => 30,
                20 => 40,
                25 => 50,
                > 30 => 60,
                _ => pipeSpeed
            };

        }

        private void GameOver()
        {
            gameTimer.Stop();
            lblScore.Text += " Game Over!!!";
        }
    }
}
