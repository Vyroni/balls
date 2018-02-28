using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ball_hitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int vdir = +1;
        int speed = 4;
        int multiplier = 0;
        bool _left = false;
        bool _right = false;
        bool over = false;

        private void vertikalus_Tick(object sender, EventArgs e)
        {
            if (ball.Top < 0)
            {
                vdir = +1;
            }
            else if (ball.Top > (this.Height - ball.Height - plank.Height))
            {
                vdir = -1;

                if (ball.Left > plank.Left && ball.Right > plank.Right)
                {
                    over = true;
                }
                else if (ball.Left < plank.Left && ball.Right < plank.Right)
                {
                    over = true;
                }
                else
                {
                    multiplier += 1;
                }

            }
           
                ball.Top += (vdir * (speed + multiplier));
           
        }

        int hdir = +1;

        private void horizantalus_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0)
            {
                hdir = +1;
            }
            else if (ball.Left > (this.Width - ball.Width))
            {
                hdir = -1;
            }
           
            
                ball.Left += (hdir * (speed + multiplier));
            
        }

        private void gaudykle_Tick(object sender, EventArgs e)
        {
            if (_right && plank.Left<(this.Width - plank.Width))
            {
                plank.Left = plank.Left + 10;
            }
            else if (_left && plank.Left > /*(this.Width - plank.Width)*/ 0)
            {
                plank.Left = plank.Left - 10;
            }

            if (over)
            {
                game_over_panel.Visible = game_over_label.Visible = true;
                horizantalus.Enabled = vertikalus.Enabled = false;
            }
            else if (!over)
            {
                game_over_panel.Visible = game_over_label.Visible = false;
                horizantalus.Enabled = vertikalus.Enabled = true;
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                _right = _left = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                _right = true;
                //_left = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                _left = true;
                //_right = false;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                over = false;
                multiplier = 0;
            }
        }

    }
}
